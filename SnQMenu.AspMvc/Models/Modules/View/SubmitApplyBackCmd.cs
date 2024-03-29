﻿//@CodeCopy
//MdStart
namespace SnQMenu.AspMvc.Models.Modules.View
{
    public partial class SubmitApplyBackCmd : SubmitApplyCmd
    {
        public SubmitApplyBackCmd()
        {
            Constructing();
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();

        public bool FromSubmitToBack { get; set; } = false;

        public string BackText { get; set; } = "Back to List";
        public string BackAction { get; set; } = "Index";
        public object BackRouteValues { get; set; }
        public string BackController { get; set; }
        public string BackCss { get; set; } = "btn btn-outline-dark";
        public string BackStyle { get; set; } = "min-width: 8em;";
    }
}
//MdEnd
