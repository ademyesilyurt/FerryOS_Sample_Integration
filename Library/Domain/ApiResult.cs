using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain
{

	public class ApiResult
	{
		public ApiResult()
		{
			Valid = new List<Validation>();
		}
		public object Result { get; set; }
		public List<Validation> Valid { get; set; }
		public int RecordCount { get; set; }
		public long ID { get; set; }
		public HttpStatusCode Status { get; set; }
	}


	public class Validation
	{
		public string Key { get; set; }
		public string Value { get; set; }
		public string Code { get; set; }
	}
}
