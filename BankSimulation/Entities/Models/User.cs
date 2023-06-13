﻿using System;
using Entities.Interfaces;

namespace Entities.Models
{
	public class User:IEntity
	{
		
		public int Id { get; set; }
		public int Balance { get; set; }
        public string Name { get; set; }
		public string SureName { get; set; }
		public int Cvv { get; set; }
		public int Pin { get; set; }
		public string cartNumbers { get; set; }
		public DateTime ActivityDate { get; set; }
		public string Phone { get; set; }
		public Bank Bank { get; set; }
		public int Depposite { get; set; }
		public bool PinBlocked { get; set; } = false;
		public User()
		{
			
		}
	}
}

