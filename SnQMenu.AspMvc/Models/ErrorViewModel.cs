﻿//@CodeCopy
//MdStart
namespace SnQMenu.AspMvc.Models
{
    public partial class ErrorViewModel
	{
		public string RequestId { get; set; }

		public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
	}
}
//MdEnd
