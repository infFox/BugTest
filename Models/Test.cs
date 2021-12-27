using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using FreeSql.DataAnnotations;

namespace BugTest.Models {

	[Table(Name = "test", DisableSyncStructure = true)]
	public partial class Test {

		[Column(Name = "id", IsPrimary = true, IsIdentity = true)]
		public uint Id { get; set; }

		[Column(Name = "a_number")]
		public int ANumber { get; set; }

		[Column(Name = "a_text", StringLength = 100, IsNullable = false)]
		public string AText { get; set; }

		[Column(Name = "bool2", DbType = "tinyint(1)")]
		public sbyte Bool2 { get; set; }

		[Column(Name = "is_abc", DbType = "tinyint(1)")]
		public sbyte IsAbc { get; set; }

		[Column(Name = "is_enabled", DbType = "tinyint(1)")]
		public sbyte IsEnabled { get; set; }

		[Column(Name = "name", StringLength = 100, IsNullable = false)]
		public string Name { get; set; }

		[Column(Name = "text2", StringLength = 100, IsNullable = false)]
		public string Text2 { get; set; }

	}

}
