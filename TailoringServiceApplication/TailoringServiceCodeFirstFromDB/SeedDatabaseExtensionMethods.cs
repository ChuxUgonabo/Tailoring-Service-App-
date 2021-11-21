using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace TailoringServiceCodeFirstFromDB
{
    public static class SeedDatabaseExtensionMethods
    {

		public static void SeedDatabase(this TailoringServiceEntities context)
		{
			// set up database log to write to output window in VS
			context.Database.Log = (s => Debug.Write(s));

			context.Database.Delete();
			context.Database.Create();

			
			List<Employee> employees = new List<Employee>()
			{
				new Employee { EmployeeName = "Mike", RoleType = "maneger" },
				new Employee { EmployeeName = "John", RoleType = "tailor" },
				new Employee { EmployeeName = "Navdeep", RoleType = "tailor" },
				new Employee { EmployeeName = "Sapreet", RoleType = "reciptionist" }
			};

			context.Employees.AddRange(employees);
			context.SaveChanges();

			List<Order> orders = new List<Order>()
			{
				new Order { CustomerName = "Honda", CustomerNumber = "Civic", Article = "Purple", Service = "Purple", Satus = "Purple", Comment = "Purple", EmployeeId = 2, PickUpDate = "time", CreateDate = "time"}
			};	

			context.Orders.AddRange(orders);
			context.SaveChanges();

			List<Measurement> measurements = new List<Measurement>()
			{
				new Measurement { Gender = "male", Bust = 15.0, Neck = 15.0, Waist = 15.0, Hip = 15.0, Shoulder = 15.0, Arm = 15.0, Leg = 15.0, OrderId = 1 },
				
			};

			context.Measurements.AddRange(measurements);
			context.SaveChanges();

			List<Bill> bills = new List<Bill>()
			{
				new Bill { Amount = 12, Payment = "Cash", Status = 0, OrderId = 1 },

			};
			context.Bills.AddRange(bills);
			context.SaveChanges();

		}



	}
}
