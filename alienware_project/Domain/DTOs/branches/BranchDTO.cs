﻿using System;
using Domain.Enums;

namespace Domain.DTOs.branches
{
	public class BranchDTO
	{
		public string BranchId { get; set; } = string.Empty;
		public string Name { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public StatusBranch Status { get; set; }
	}
}

