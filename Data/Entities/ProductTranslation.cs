using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
	public class ProductTranslation
	{
		public int ProductTranslationId { get; set; }
		public int ProductId { get; set; }
		public int ProductName { get; set; }
		public string Description { get; set; }
		public string Detail {  get; set; }
		public string SeoDecription { get; set; }
		public string SeoTitle { get; set; }
		public string SeoAlias { get; set; }
		public int AuthorId { get; set; }
		public int PublisherId { get; set; }
		public int LanguageId { get; set; }

		public Product Product { get; set; }
		public Author Author { get; set; }
		public Publisher Publisher { get; set; }
	}
}
