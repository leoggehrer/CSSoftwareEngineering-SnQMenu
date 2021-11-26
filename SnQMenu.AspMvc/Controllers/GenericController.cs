﻿//@CodeCopy
//MdStart
using CommonBase.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using SnQMenu.AspMvc.Models;
using SnQMenu.AspMvc.Models.Modules.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnQMenu.AspMvc.Controllers
{
    public abstract partial class GenericController<TContract, TModel> : MvcController
        where TContract : Contracts.IIdentifiable, Contracts.ICopyable<TContract>
        where TModel : TContract, new()
    {
        static GenericController()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();

        internal GenericController()
        {
            Constructing();
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();

        protected virtual Contracts.Client.IAdapterAccess<TContract> CreateController()
        {
            return CreateController<TContract>();
        }
        protected virtual Contracts.Client.IAdapterAccess<T> CreateController<T>()
            where T : Contracts.IIdentifiable, Contracts.ICopyable<T>
        {
            var handled = false;
            var result = default(Contracts.Client.IAdapterAccess<T>);

            BeforeCreateController(ref result, ref handled);
            if (handled == false)
            {
                result = Adapters.Factory.Create<T>();
#if ACCOUNT_ON
                result.SessionToken = SessionWrapper?.SessionToken;
#endif
            }
            AfterCreateController(result);
            return result;
        }
        partial void BeforeCreateController<T>(ref Contracts.Client.IAdapterAccess<T> controller, ref bool handled);
        partial void AfterCreateController<T>(Contracts.Client.IAdapterAccess<T> controller);

        protected bool FromCreateToEdit { get; set; } = false;
        protected bool FromEditToIndex { get; set; } = true;
        protected string ControllerName => GetType().Name.Replace("Controller", string.Empty);

        protected virtual TModel ToModel(TContract entity)
        {
            entity.CheckArgument(nameof(entity));

            var result = new TModel();

            result.CopyProperties(entity);
            return result;
        }
        protected virtual TModel BeforeView(TModel model, ActionMode action) => model;
        protected virtual IEnumerable<TModel> BeforeView(IEnumerable<TModel> models, ActionMode action) => models;
        protected virtual Task<TModel> BeforeViewAsync(TModel model, ActionMode action) => Task.FromResult(model);
        protected virtual Task<IEnumerable<TModel>> BeforeViewAsync(IEnumerable<TModel> models, ActionMode action) => Task.FromResult(models);

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            ViewBag.ViewModelCreator = new Modules.View.ViewModelCreator();

            base.OnActionExecuted(context);
        }

        protected virtual async Task<TModel> GetModelAsync(int id)
        {
            var handled = false;
            var model = default(TModel);

            BeforeGetModel(ref model, ref handled);
            if (handled == false)
            {
                using var ctrl = CreateController();
                var entity = await ctrl.GetByIdAsync(id).ConfigureAwait(false);

                model = ToModel(entity);
            }
            AfterGetModel(model);
            return model;
        }
        partial void BeforeGetModel(ref TModel model, ref bool handled);
        partial void AfterGetModel(TModel model);

        [HttpGet]
        [ActionName("Index")]
        public virtual async Task<IActionResult> IndexAsync()
        {
            var handled = false;
            var models = default(IEnumerable<TModel>);

            BeforeIndex(ref models, ref handled);
            if (handled == false)
            {
                try
                {
                    using var ctrl = CreateController();
                    var pageCount = await ctrl.CountAsync().ConfigureAwait(false);
                    var pageIndex = SessionWrapper.GetPageIndex(ControllerName);
                    var pageSize = SessionWrapper.GetPageSize(ControllerName);
                    var entities = await ctrl.GetPageListAsync(pageIndex, pageSize).ConfigureAwait(false);

                    pageIndex = pageIndex * pageSize > pageCount ? 0 : pageIndex;
                    SessionWrapper.SetPageCount(ControllerName, pageCount);
                    SessionWrapper.SetPageIndex(ControllerName, pageIndex);
                    SessionWrapper.SetPageSize(ControllerName, pageSize);
                    models = entities.Select(e => ToModel(e));
                    models = BeforeView(models, ActionMode.Index);
                    models = await BeforeViewAsync(models, ActionMode.Index).ConfigureAwait(false);
                }
                catch (Exception ex)
                {
                    LastViewError = ex.GetError();
                }
            }
            AfterIndex(models);
            return ReturnIndexView(models);
        }
        partial void BeforeIndex(ref IEnumerable<TModel> models, ref bool handled);
        partial void AfterIndex(IEnumerable<TModel> models);
        protected virtual IActionResult ReturnIndexView(IEnumerable<TModel> models) => View("Index", models);

        [HttpGet]
        [ActionName("IndexByPageIndex")]
        public virtual async Task<IActionResult> IndexByPageIndexAsync(int pageIndex, int pageSize)
        {
            var handled = false;
            var models = default(IEnumerable<TModel>);

            BeforeIndexByPageIndex(pageIndex, pageSize, ref models, ref handled);
            if (handled == false)
            {
                try
                {
                    using var ctrl = CreateController();
                    var pageCount = await ctrl.CountAsync().ConfigureAwait(false);
                    var entities = await ctrl.GetPageListAsync(pageIndex, pageSize).ConfigureAwait(false);

                    pageIndex = pageIndex * pageSize > pageCount ? 0 : pageIndex;
                    SessionWrapper.SetPageCount(ControllerName, pageCount);
                    SessionWrapper.SetPageIndex(ControllerName, pageIndex);
                    SessionWrapper.SetPageSize(ControllerName, pageSize);
                    models = entities.Select(e => ToModel(e));
                    models = BeforeView(models, ActionMode.Index);
                    models = await BeforeViewAsync(models, ActionMode.Index).ConfigureAwait(false);
                }
                catch (Exception ex)
                {
                    LastViewError = ex.GetError();
                }
            }
            AfterIndexByPageIndex(models);
            return ReturnIndexView(models);
        }
        partial void BeforeIndexByPageIndex(int pageIndex, int pageSize, ref IEnumerable<TModel> models, ref bool handled);
        partial void AfterIndexByPageIndex(IEnumerable<TModel> models);

        [HttpGet]
        [ActionName("IndexByPageSize")]
        public virtual async Task<IActionResult> IndexByPageSizeAsync(int pageSize)
        {
            var handled = false;
            var models = default(IEnumerable<TModel>);

            BeforeIndexByPageSize(pageSize, ref models, ref handled);
            if (handled == false)
            {
                try
                {
                    using var ctrl = CreateController();
                    var pageCount = await ctrl.CountAsync().ConfigureAwait(false);
                    var entities = await ctrl.GetPageListAsync(0, pageSize).ConfigureAwait(false);

                    SessionWrapper.SetPageCount(ControllerName, pageCount);
                    SessionWrapper.SetPageIndex(ControllerName, 0);
                    SessionWrapper.SetPageSize(ControllerName, pageSize);
                    models = entities.Select(e => ToModel(e));
                    models = BeforeView(models, ActionMode.Index);
                    models = await BeforeViewAsync(models, ActionMode.Index).ConfigureAwait(false);
                }
                catch (Exception ex)
                {
                    LastViewError = ex.GetError();
                }
            }
            AfterIndexByPageSize(models);
            return ReturnIndexView(models);
        }
        partial void BeforeIndexByPageSize(int pageSize, ref IEnumerable<TModel> models, ref bool handled);
        partial void AfterIndexByPageSize(IEnumerable<TModel> models);

        [HttpGet]
        [ActionName("Create")]
        public virtual async Task<IActionResult> CreateAsync()
        {
            var handled = false;
            var model = default(TModel);

            BeforeCreate(ref model, ref handled);
            if (handled == false)
            {
                try
                {
                    LastViewError = string.Empty;
                    model = await CreateModelAsync().ConfigureAwait(false);
                }
                catch (Exception ex)
                {
                    LastViewError = ex.GetError();
                }
            }
            AfterCreate(model);
            if (HasError == false)
            {
                model = BeforeView(model, ActionMode.Create);
                model = await BeforeViewAsync(model, ActionMode.Create).ConfigureAwait(false);
            }
            return HasError ? RedirectToAction("Index") : ReturnCreateView(model);
        }
        partial void BeforeCreate(ref TModel model, ref bool handled);
        partial void AfterCreate(TModel model);
        protected virtual IActionResult ReturnCreateView(TModel model) => View("Create", model);

        protected virtual async Task<TModel> CreateModelAsync()
        {
            var handled = false;
            var model = default(TModel);

            BeforeCreateModel(ref model, ref handled);
            if (handled == false)
            {
                using var ctrl = CreateController();
                var entity = await ctrl.CreateAsync().ConfigureAwait(false);

                model = ToModel(entity);
            }
            AfterCreateModel(model);
            return model;
        }
        partial void BeforeCreateModel(ref TModel model, ref bool handled);
        partial void AfterCreateModel(TModel model);


        [HttpPost]
        [ActionName("Create")]
        public virtual async Task<IActionResult> InsertAsync(TModel model)
        {
            var handled = false;

            BeforeInsertModel(model, ref handled);
            if (handled == false)
            {
                try
                {
                    using var ctrl = CreateController();
                    var entity = await ctrl.InsertAsync(model).ConfigureAwait(false);

                    model.CopyProperties(entity);
                    LastViewError = string.Empty;
                }
                catch (Exception ex)
                {
                    LastViewError = ex.GetError();
                }
            }
            AfterInsertModel(model);
            if (HasError == false)
            {
                model = BeforeView(model, ActionMode.Create);
                model = await BeforeViewAsync(model, ActionMode.Create).ConfigureAwait(false);
            }
            return ReturnAfterCreate(HasError, model);
        }
        partial void BeforeInsertModel(TModel model, ref bool handled);
        partial void AfterInsertModel(TModel model);
        protected virtual IActionResult ReturnAfterCreate(bool hasError, TModel model) => hasError ? View("Create", model) : FromCreateToEdit ? RedirectToAction("Edit", new { model.Id }) : RedirectToAction("Index");

        [HttpGet]
        [ActionName("Edit")]
        public virtual async Task<IActionResult> EditAsync(int id)
        {
            var handled = false;
            var model = default(TModel);

            BeforeEdit(ref model, ref handled);
            if (handled == false)
            {
                try
                {
                    model = await EditModelAsync(id).ConfigureAwait(false);
                    LastViewError = string.Empty;
                }
                catch (Exception ex)
                {
                    LastViewError = ex.GetError();
                }
            }
            AfterEdit(model);
            if (HasError == false)
            {
                model = BeforeView(model, ActionMode.Edit);
                model = await BeforeViewAsync(model, ActionMode.Edit).ConfigureAwait(false);
            }
            return HasError ? RedirectToAction("Index") : ReturnEditView(model);
        }
        partial void BeforeEdit(ref TModel model, ref bool handled);
        partial void AfterEdit(TModel model);
        protected virtual IActionResult ReturnEditView(TModel model) => View("Edit", model);

        protected virtual async Task<TModel> EditModelAsync(int id)
        {
            var handled = false;
            var model = default(TModel);

            BeforeEditModel(ref model, ref handled);
            if (handled == false)
            {
                using var ctrl = CreateController();
                var entity = await ctrl.GetByIdAsync(id).ConfigureAwait(false);

                model = ToModel(entity);
            }
            AfterEditModel(model);
            return model;
        }
        partial void BeforeEditModel(ref TModel model, ref bool handled);
        partial void AfterEditModel(TModel model);

        [HttpPost]
        [ActionName("Edit")]
        public virtual async Task<IActionResult> Update(TModel model)
        {
            var handled = false;

            BeforeUpdateModel(model, ref handled);
            if (handled == false)
            {
                try
                {
                    using var ctrl = CreateController();

                    if (model is IMasterDetails modelMasterDetail)
                    {
                        var entity = await ctrl.GetByIdAsync(model.Id).ConfigureAwait(false);
                        var entityModel = ToModel(entity);

                        if (entityModel is IMasterDetails entityMasterDetail)
                        {
                            entityMasterDetail.Master.CopyFrom(modelMasterDetail.Master);
                            entity = await ctrl.UpdateAsync(entityModel).ConfigureAwait(false);
                        }
                        model.CopyProperties(entity);
                    }
                    else
                    {
                        var entity = await ctrl.UpdateAsync(model).ConfigureAwait(false);

                        model.CopyProperties(entity);
                    }
                    LastViewError = string.Empty;
                }
                catch (Exception ex)
                {
                    LastViewError = ex.GetError();
                }
            }
            AfterUpdateModel(model);
            if (HasError == false)
            {
                model = BeforeView(model, ActionMode.Edit);
                model = await BeforeViewAsync(model, ActionMode.Edit).ConfigureAwait(false);
            }
            return ReturnAfterEdit(HasError, model);
        }
        partial void BeforeUpdateModel(TModel model, ref bool handled);
        partial void AfterUpdateModel(TModel model);
        protected virtual IActionResult ReturnAfterEdit(bool hasError, TModel model) => hasError ? View("Edit", model) : FromEditToIndex ? RedirectToAction("Index") : RedirectToAction("Edit", new { model.Id });

        [HttpGet]
        [ActionName("Delete")]
        public virtual async Task<IActionResult> ViewDeleteAsync(int id)
        {
            var handled = false;
            var model = default(TModel);

            BeforeDelete(ref model, ref handled);
            if (handled == false)
            {
                try
                {
                    using var ctrl = CreateController();
                    var entity = await ctrl.GetByIdAsync(id).ConfigureAwait(false);

                    model = ToModel(entity);
                    LastViewError = string.Empty;
                }
                catch (Exception ex)
                {
                    LastViewError = ex.GetError();
                }
            }
            AfterDelete(model);
            if (HasError == false)
            {
                model = BeforeView(model, ActionMode.Delete);
                model = await BeforeViewAsync(model, ActionMode.Delete).ConfigureAwait(false);
            }
            return HasError ? RedirectToAction("Index") : ReturnDeleteView(model);
        }
        partial void BeforeDelete(ref TModel model, ref bool handled);
        partial void AfterDelete(TModel model);
        protected virtual IActionResult ReturnDeleteView(TModel model) => View("Delete", model);

        [ActionName("Delete")]
        public virtual async Task<IActionResult> DeleteAsync(int id)
        {
            var handled = false;
            var model = default(TModel);

            BeforeDeleteModel(id, ref handled);
            if (handled == false)
            {
                try
                {
                    using var ctrl = CreateController();

                    await ctrl.DeleteAsync(id).ConfigureAwait(false);
                    LastViewError = string.Empty;
                }
                catch (Exception ex)
                {
                    LastViewError = ex.GetError();
                }
            }
            AfterDeleteModel(id);
            if (HasError)
            {
                using var ctrl = CreateController();
                var entity = await ctrl.GetByIdAsync(id).ConfigureAwait(false);

                model = ToModel(entity);
            }
            return ReturnAfterDelete(HasError, model);
        }
        partial void BeforeDeleteModel(int id, ref bool handled);
        partial void AfterDeleteModel(int id);
        protected virtual IActionResult ReturnAfterDelete(bool hasError, TModel model) => hasError ? View("Delete", model) : RedirectToAction("Index");

        [HttpGet]
        [ActionName("Details")]
        public virtual async Task<IActionResult> DetailsAsync(int id)
        {
            var handled = false;
            var model = default(TModel);

            BeforeDetails(ref model, ref handled);
            if (handled == false)
            {
                try
                {
                    model = await GetModelAsync(id).ConfigureAwait(false);
                    LastViewError = string.Empty;
                }
                catch (Exception ex)
                {
                    LastViewError = ex.GetError();
                }
            }
            AfterEdit(model);
            if (HasError == false)
            {
                model = BeforeView(model, ActionMode.Details);
                model = await BeforeViewAsync(model, ActionMode.Details).ConfigureAwait(false);
            }
            return HasError ? RedirectToAction("Index") : ReturnDetailsView(model);
        }
        partial void BeforeDetails(ref TModel model, ref bool handled);
        partial void AfterDetails(TModel model);
        protected virtual IActionResult ReturnDetailsView(TModel model) => View("Details", model);

        #region Detail actions
        [HttpGet]
        [ActionName("CreateDetail")]
        public virtual async Task<IActionResult> CreateDetailAsync(int id)
        {
            var handled = false;
            var model = default(TModel);
            var masterDetailModel = new Models.MasterDetailModel();

            BeforeCreateDetail(ref model, ref handled);
            if (handled == false)
            {
                try
                {
                    LastViewError = string.Empty;
                    model = await GetModelAsync(id).ConfigureAwait(false);

                    if (model != null)
                    {
                        var oneProperty = model.GetType().GetProperty("OneModel");
                        var oneModel = oneProperty?.GetValue(model) as Models.IdentityModel;
                        var createManyMethod = model.GetType().GetMethod("CreateManyModel");
                        var manyModel = createManyMethod?.Invoke(model, new object[] { }) as Models.IdentityModel;

                        masterDetailModel.Master = oneModel;
                        masterDetailModel.Detail = manyModel;
                    }
                }
                catch (Exception ex)
                {
                    LastViewError = ex.GetError();
                }
            }
            AfterCreateDetail(model);
            if (HasError == false)
            {
                model = BeforeView(model, ActionMode.CreateDetail);
                model = await BeforeViewAsync(model, ActionMode.CreateDetail).ConfigureAwait(false);
            }
            return HasError ? RedirectToAction("Index") : ReturnCreateDetailView(masterDetailModel);
        }
        partial void BeforeCreateDetail(ref TModel model, ref bool handled);
        partial void AfterCreateDetail(TModel model);
        protected virtual IActionResult ReturnCreateDetailView(Models.MasterDetailModel model) => View("CreateDetail", model);

        [HttpPost]
        [ActionName("CreateDetail")]
        public virtual async Task<IActionResult> AddDetailAsync(int id, IFormCollection formCollection)
        {
            var handled = false;
            var model = default(TModel);
            var masterDetailModel = new Models.MasterDetailModel();

            BeforeAddDetail(ref model, ref handled);
            if (handled == false)
            {
                try
                {
                    model = await GetModelAsync(id).ConfigureAwait(false);
                    if (model != null)
                    {
                        var oneProperty = model.GetType().GetProperty("OneModel");
                        var oneModel = oneProperty?.GetValue(model) as Models.IdentityModel;
                        var createManyMethod = model.GetType().GetMethod("CreateManyModel");
                        var manyModel = createManyMethod?.Invoke(model, new object[] { }) as Models.IdentityModel;
                        var addManyMethod = model.GetType().GetMethod("AddManyItem");

                        masterDetailModel.Master = oneModel;
                        masterDetailModel.Detail = manyModel;
                        SetModelValues(masterDetailModel.Detail, nameof(Models.MasterDetailModel.Detail), formCollection);
                        addManyMethod?.Invoke(model, new object[] { masterDetailModel.Detail });

                        using var ctrl = CreateController();
                        var entity = await ctrl.UpdateAsync(model).ConfigureAwait(false);

                        model.CopyProperties(entity);
                    }
                    LastViewError = string.Empty;
                }
                catch (Exception ex)
                {
                    LastViewError = ex.GetError();
                }
            }
            AfterAddDetail(model);
            if (HasError == false)
            {
                model = BeforeView(model, ActionMode.CreateDetail);
                model = await BeforeViewAsync(model, ActionMode.CreateDetail).ConfigureAwait(false);
            }
            return HasError ? ReturnCreateDetailView(masterDetailModel) : RedirectToAction("Details", new { id = model.Id });
        }
        partial void BeforeAddDetail(ref TModel model, ref bool handled);
        partial void AfterAddDetail(TModel model);

        [HttpGet]
        [ActionName("EditDetail")]
        public virtual async Task<IActionResult> EditDetailAsync(int id, int detailId)
        {
            var handled = false;
            var model = default(TModel);
            var masterDetailModel = new Models.MasterDetailModel();

            BeforeEditDetail(ref model, ref handled);
            if (handled == false)
            {
                try
                {
                    LastViewError = string.Empty;
                    model = await GetModelAsync(id).ConfigureAwait(false);

                    if (model != null)
                    {
                        var oneProperty = model.GetType().GetProperty("OneModel");
                        var oneModel = oneProperty?.GetValue(model) as Models.IdentityModel;
                        var getManyMethod = model.GetType().GetMethod("GetManyModelById");
                        var manyModel = getManyMethod?.Invoke(model, new object[] { detailId }) as Models.IdentityModel;

                        masterDetailModel.Master = oneModel;
                        masterDetailModel.Detail = manyModel;
                    }
                }
                catch (Exception ex)
                {
                    LastViewError = ex.GetError();
                }
            }
            AfterEditDetail(model);
            if (HasError == false)
            {
                model = BeforeView(model, ActionMode.CreateDetail);
                model = await BeforeViewAsync(model, ActionMode.CreateDetail).ConfigureAwait(false);
            }
            return HasError ? RedirectToAction("Index") : ReturnEditDetailView(masterDetailModel);
        }
        partial void BeforeEditDetail(ref TModel model, ref bool handled);
        partial void AfterEditDetail(TModel model);
        protected virtual IActionResult ReturnEditDetailView(Models.MasterDetailModel model) => View("EditDetail", model);

        [HttpPost]
        [ActionName("EditDetail")]
        public virtual async Task<IActionResult> EditDetailAsync(int id, IFormCollection formCollection)
        {
            var handled = false;
            var model = default(TModel);
            var masterDetailModel = new Models.MasterDetailModel();

            BeforeUpdateDetail(ref model, ref handled);
            if (handled == false)
            {
                try
                {
                    model = await GetModelAsync(id).ConfigureAwait(false);
                    if (model != null)
                    {
                        var oneProperty = model.GetType().GetProperty("OneModel");
                        var oneModel = oneProperty?.GetValue(model) as Models.IdentityModel;
                        var getManyMethod = model.GetType().GetMethod("GetManyModelById");

                        if (GetObjectId(nameof(Models.MasterDetailModel.Detail), formCollection, out int detailId))
                        {
                            var manyModel = getManyMethod?.Invoke(model, new object[] { detailId }) as Models.IdentityModel;

                            masterDetailModel.Master = oneModel;
                            masterDetailModel.Detail = manyModel;
                            SetModelValues(masterDetailModel.Detail, nameof(Models.MasterDetailModel.Detail), formCollection);
                        }

                        using var ctrl = CreateController();
                        var entity = await ctrl.UpdateAsync(model).ConfigureAwait(false);

                        model.CopyProperties(entity);
                    }
                    LastViewError = string.Empty;
                }
                catch (Exception ex)
                {
                    LastViewError = ex.GetError();
                }
            }
            AfterUpdateDetail(model);
            if (HasError == false)
            {
                model = BeforeView(model, ActionMode.CreateDetail);
                model = await BeforeViewAsync(model, ActionMode.CreateDetail).ConfigureAwait(false);
            }
            return HasError ? ReturnCreateDetailView(masterDetailModel) : RedirectToAction("Details", new { id = model.Id });
        }
        partial void BeforeUpdateDetail(ref TModel model, ref bool handled);
        partial void AfterUpdateDetail(TModel model);

        [HttpGet]
        [ActionName("DeleteDetail")]
        public virtual async Task<IActionResult> ViewDeleteDetailAsync(int id, int detailId)
        {
            var handled = false;
            var model = default(TModel);
            var masterDetailModel = new Models.MasterDetailModel();

            BeforeViewDeleteDetail(ref model, ref handled);
            if (handled == false)
            {
                try
                {
                    LastViewError = string.Empty;
                    model = await GetModelAsync(id).ConfigureAwait(false);

                    if (model != null)
                    {
                        var oneProperty = model.GetType().GetProperty("OneModel");
                        var oneModel = oneProperty?.GetValue(model) as Models.IdentityModel;
                        var getManyMethod = model.GetType().GetMethod("GetManyModelById");
                        var manyModel = getManyMethod?.Invoke(model, new object[] { detailId }) as Models.IdentityModel;

                        masterDetailModel.Master = oneModel;
                        masterDetailModel.Detail = manyModel;
                    }
                }
                catch (Exception ex)
                {
                    LastViewError = ex.GetError();
                }
            }
            AfterViewDeleteDetail(model);
            if (HasError == false)
            {
                model = BeforeView(model, ActionMode.CreateDetail);
                model = await BeforeViewAsync(model, ActionMode.CreateDetail).ConfigureAwait(false);
            }
            return HasError ? RedirectToAction("Index") : ReturnDeleteDetailView(masterDetailModel);
        }
        partial void BeforeViewDeleteDetail(ref TModel model, ref bool handled);
        partial void AfterViewDeleteDetail(TModel model);
        protected virtual IActionResult ReturnDeleteDetailView(Models.MasterDetailModel model) => View("DeleteDetail", model);

        [HttpPost]
        [ActionName("DeleteDetail")]
        public virtual async Task<IActionResult> DeleteDetailAsync(int id, IFormCollection formCollection)
        {
            var handled = false;
            var model = default(TModel);
            var masterDetailModel = new Models.MasterDetailModel();

            BeforeDeleteDetail(ref model, ref handled);
            if (handled == false)
            {
                try
                {
                    model = await GetModelAsync(id).ConfigureAwait(false);
                    if (model != null)
                    {
                        var oneProperty = model.GetType().GetProperty("OneModel");
                        var oneModel = oneProperty?.GetValue(model) as Models.IdentityModel;
                        var removeManyMethod = model.GetType().GetMethod("RemoveManyModel");

                        if (GetObjectId(nameof(Models.MasterDetailModel.Detail), formCollection, out int detailId))
                        {
                            var getManyMethod = model.GetType().GetMethod("GetManyModelById");
                            var manyModel = getManyMethod?.Invoke(model, new object[] { detailId }) as Models.IdentityModel;

                            removeManyMethod?.Invoke(model, new object[] { detailId });

                            masterDetailModel.Master = oneModel;
                            masterDetailModel.Detail = manyModel;
                        }

                        using var ctrl = CreateController();
                        var entity = await ctrl.UpdateAsync(model).ConfigureAwait(false);

                        model.CopyProperties(entity);
                    }
                    LastViewError = string.Empty;
                }
                catch (Exception ex)
                {
                    LastViewError = ex.GetError();
                }
            }
            AfterDeleteDetail(model);
            if (HasError == false)
            {
                model = BeforeView(model, ActionMode.CreateDetail);
                model = await BeforeViewAsync(model, ActionMode.CreateDetail).ConfigureAwait(false);
            }
            return HasError ? ReturnDeleteDetailView(masterDetailModel) : RedirectToAction("Details", new { id = model.Id });
        }
        partial void BeforeDeleteDetail(ref TModel model, ref bool handled);
        partial void AfterDeleteDetail(TModel model);
        #endregion Detail actions

        public static bool GetObjectId(string prefix, IFormCollection formCollection, out int id)
        {
            formCollection.CheckArgument(nameof(formCollection));

            var result = false;
            var formKey = $"{prefix}.Id";

            if (formCollection.Keys.Contains(formKey))
            {
                var formValue = formCollection[formKey].FirstOrDefault();

                result = Int32.TryParse(formValue, out id);
            }
            else
            {
                id = 0;
            }
            return result;
        }
        public static void SetModelValues(object model, string prefix, IFormCollection formCollection)
        {
            model.CheckArgument(nameof(model));
            formCollection.CheckArgument(nameof(formCollection));

            foreach (var pi in model.GetType().GetProperties().Where(pi => pi.CanWrite))
            {
                var formKey = $"{prefix}.{pi.Name}";

                if (formCollection.Keys.Contains(formKey))
                {
                    var formValue = formCollection[formKey].FirstOrDefault();

                    if (pi.PropertyType.IsEnum)
                    {
                        if (Int32.TryParse(formValue, out int enumVal))
                        {
                            object value = Enum.Parse(pi.PropertyType, enumVal.ToString());

                            pi.SetValue(model, value);
                        }
                    }
                    else if (pi.PropertyType == typeof(string))
                    {
                        pi.SetValue(model, string.IsNullOrEmpty(formValue) ? null : formValue);
                    }
                    else if (pi.PropertyType == typeof(DateTime))
                    {
                        pi.SetValue(model, string.IsNullOrEmpty(formValue) ? null : System.DateTime.Parse(formValue));
                    }
                    else if (pi.PropertyType == typeof(Nullable<DateTime>))
                    {
                        pi.SetValue(model, string.IsNullOrEmpty(formValue) ? null : System.DateTime.Parse(formValue));
                    }
                    else if (pi.PropertyType == typeof(Guid))
                    {
                        if (Guid.TryParse(formValue, out Guid guidVal))
                        {
                            pi.SetValue(model, guidVal);
                        }
                    }
                    else if (pi.PropertyType == typeof(Nullable<Guid>))
                    {
                        if (string.IsNullOrEmpty(formValue) == false && Guid.TryParse(formValue, out Guid guidVal))
                        {
                            pi.SetValue(model, guidVal);
                        }
                    }
                    else
                    {
                        object value = Convert.ChangeType(formValue, pi.PropertyType);

                        pi.SetValue(model, value);
                    }
                }
            }
        }
    }
}
//MdEnd
