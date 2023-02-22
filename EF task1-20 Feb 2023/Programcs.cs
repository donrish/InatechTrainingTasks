using EFCONSOLE.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Data;

namespace EFCONSOLE
{
    internal class Programcs
    {
        public static void InsertProduct()
        {
            using (var dbcon =new context())
            {
                product prod = new product();
                prod.Name = "lyril";
                dbcon.Add(prod);
                prod = new product();
                prod.Name = "Medimix";
                dbcon.Add(prod);
                dbcon.SaveChanges();
            }
            return;
        }
        public static void ReadProduct() 
        {
            using (var dbcon = new context()) 
            {
                //List<product> prods = new List<product>();
                List<product> prods =dbcon.Products.ToList();
                foreach(var pr in prods) // var pr in dbcon.products also 
                {
                Console.WriteLine(pr.Name + " " + pr.Id);
                }
            }
        }
        public static void Updateproduct() //read and update needed
        {
            using( var dbcon = new context())   
            {
                product? prd = dbcon.Products.Find(4);
                prd.Name = "Dove";
                dbcon.SaveChanges();
            }
        }

        public static void DeleteProduct() 
        {
        using (var dbcon = new context())
            {
                product? prodss= dbcon.Products.Find(3);
                dbcon.Products.Remove(prodss);
                dbcon.SaveChanges() ;   
            }
        }

        //prodbatch

        public static void Insertbatch()
        {
            using (var db = new context())
            {
                prodbatch pb = new prodbatch();
                pb.batchId= 1;
                pb.Price = 150;
                pb.Quantity = 100;
                pb.Description = "THIS IS GREAT";
               // pb.Product = 10;
                db.SaveChanges();
                    }

            //using System;
            //using System.Collections.Generic;
            //using System.ComponentModel.DataAnnotations;
            //using System.ComponentModel.DataAnnotations.Schema;
            //using System.Linq;
            //using System.Text;
            //using System.Threading.Tasks;

//namespace EF_console.Model
//    {
//        internal class ProductBatch
//        {
//            [Key]
//            public int BatchId { get; set; }
//            public int ProductId { get; set; }
//            public string? Description { get; set; }
//            public double Price { get; set; }
//            [ForeignKey("Product")]
//            [Column(Order = 1)]
//            public int ID { get; set; }
//            //  public Product 
//            public Product Product { get; set; }
//        }
//    }
}
        //public static void Main(string[] args)
        //{
        //    //InsertProduct(); //comment this if u dont need old values
        //    ReadProduct();
        //   // Updateproduct();
        //    DeleteProduct();
        //    Insertbatch();
        //    Console.WriteLine("Success");
        //}

        //13feb 

        public static void Insertstandard()
        {
            using (var dbcon = new context())
            {
                Standard sta = new Standard();
                sta.Standardname = "Praggi";
                dbcon.Add(sta);
                //sta = new Standard();  no need  
                //sta.Standardid = 1;
                //dbcon.Add(sta);
                dbcon.SaveChanges();
                    }
            return;
        }

        public static void Insertstudent13()
        {
            using (var dbcon = new context())
            {
                student13feb stu = new student13feb();
                stu.StudentName = "ram";
                stu.Standardrefid = 2;
                dbcon.Add(stu);
                //stu = new student13feb();
                //stu.Standardrefid = 2;
                //dbcon.Add(stu);
                dbcon.SaveChanges();
            }
            return;
        }
        public static void Readstandard()
        {
            using (var dbcon = new context())
            {
                List<Standard> stand = dbcon.standards.ToList();
                foreach (var st in stand) // var pr in dbcon.products also 
                {
                    Console.WriteLine(st.Standardname + " " + st.Standardid);
                }
            }
        }

        public static void Readstudent()
        {
            using (var dbcon = new context())
            {
                List<student13feb> stud = dbcon.students.ToList();
                foreach (var stu in stud) // var pr in dbcon.products also 
                {
                    Console.WriteLine(stu.Studentid + " " + stu.StudentName + " " + stu.Standardrefid);
                }
            }
        }

        public static void Main(string[] args)
        {
            //Insertstandard();
            //Insertstudent13();
            //Readstandard();
            //Readstudent(); 
            Console.WriteLine("success");
        }
    }
}
