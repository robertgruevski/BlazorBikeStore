using System.ComponentModel.DataAnnotations;

namespace BlazorBikeStore.Models
{
	public class Bike
	{
		public int BikeId { get; set; } // Primary Key for Bike table

		[Required(ErrorMessage = "Please enter manufacturer")]
		[StringLength(50, MinimumLength = 3, ErrorMessage = "Manufacturer must be between 3 and 50 characters")]
		public string? Manufacturer { get; set; }

		[Required(ErrorMessage = "Please enter model")]
		[StringLength(60, MinimumLength = 3, ErrorMessage = "Model must be between 3 and 60 characters")]
		public string? Model { get; set; }

		[Required(ErrorMessage = "Please enter year")]
		[Range(1900, 2100, ErrorMessage = "Please enter a valid year between 1900 and 2100")]
		public int? Year { get; set; }

		[Required(ErrorMessage = "Please enter a Price")]
		[DataType(DataType.Currency)]
		[Range(1, 100000, ErrorMessage = "Please enter a valid price between 1 and 100000")]
		public decimal? Price { get; set; }

		[Required]
		public DateOnly CreatedOn { get; set; }

		[Required]
		[Range(1, 5)]
		public double Rating { get; set; }
	}
}
