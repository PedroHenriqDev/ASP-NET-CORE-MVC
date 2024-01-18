using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if(_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return; // DB has been seeded   
            }

            Department d1 = new Department(1, "Games");
            Department d2 = new Department(2, "Electronics");
            Department d3 = new Department(3, "Cars");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "John Brown", "john@gmail.com", new DateTime(1997, 5, 16), 1000.0, d1);
            Seller s2 = new Seller(2, "Marie Campbell", "marie@gmail.com", new DateTime(1992, 12, 11), 2000.0, d2);
            Seller s3 = new Seller(3, "Eliot Hill", "elhill@gmail.com", new DateTime(1997, 5, 16), 3000.0, d1);
            Seller s4 = new Seller(4, "Martha Rodriguez", "rodriguez@gmail.com", new DateTime(1997, 5, 16), 2000.0, d4);
            Seller s5 = new Seller(5, "Luiz Oliveira", "oliver@gmail.com", new DateTime(1997, 5, 16), 2000.0, d3);
            Seller s6 = new Seller(6, "Donald Grimes", "donald@gmail.com", new DateTime(1997, 5, 16), 1000.0, d2);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2023, 09, 25), 100.0, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2021, 09, 4), 7000.0, SaleStatus.Billed, s5);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2022, 09, 13), 400.0, SaleStatus.Canceled, s4);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2021, 09, 1), 200.0, SaleStatus.Billed, s1);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2023, 09, 21), 13000.0, SaleStatus.Billed, s3);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2021, 09, 15), 200.0, SaleStatus.Billed, s1);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2023, 09, 28), 3000.0, SaleStatus.Billed, s2);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2021, 09, 11), 400.0, SaleStatus.Billed, s4);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2021, 09, 14), 11000.0, SaleStatus.Pending, s6);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2022, 09, 7), 9000.0, SaleStatus.Billed, s6);
            SalesRecord r11 = new SalesRecord(11, new DateTime(2022, 09, 13), 6000.0, SaleStatus.Billed, s2);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2022, 09, 25), 200.0, SaleStatus.Pending, s3);
            SalesRecord r13 = new SalesRecord(13, new DateTime(2021, 09, 29), 100.0, SaleStatus.Billed, s4);
            SalesRecord r14 = new SalesRecord(14, new DateTime(2022, 09, 4), 33000.0, SaleStatus.Billed, s5);
            SalesRecord r15 = new SalesRecord(15, new DateTime(2023, 09, 12), 400.0, SaleStatus.Billed, s1);
            SalesRecord r16 = new SalesRecord(16, new DateTime(2023, 10, 5), 200.0, SaleStatus.Billed, s4);
            SalesRecord r17 = new SalesRecord(17, new DateTime(2023, 10, 1), 200.0, SaleStatus.Billed, s1);
            SalesRecord r18 = new SalesRecord(18, new DateTime(2019, 10, 24), 600.0, SaleStatus.Billed, s3);
            SalesRecord r19 = new SalesRecord(19, new DateTime(2019, 10, 22), 38000.0, SaleStatus.Billed, s5);
            SalesRecord r20 = new SalesRecord(20, new DateTime(2019, 10, 15), 8000.0, SaleStatus.Billed, s6);
            SalesRecord r21 = new SalesRecord(21, new DateTime(2019, 09, 17), 9000.0, SaleStatus.Billed, s2);
            SalesRecord r22 = new SalesRecord(22, new DateTime(2019, 12, 24), 400.0, SaleStatus.Billed, s4);
            SalesRecord r23 = new SalesRecord(23, new DateTime(2021, 11, 19), 11000.0, SaleStatus.Canceled, s2);
            SalesRecord r24 = new SalesRecord(24, new DateTime(2021, 11, 12), 8000.0, SaleStatus.Billed, s5);
            SalesRecord r25 = new SalesRecord(25, new DateTime(2022, 08, 31), 200.0, SaleStatus.Billed, s3);
            SalesRecord r26 = new SalesRecord(26, new DateTime(2023, 07, 6), 500.0, SaleStatus.Billed, s4);
            SalesRecord r27 = new SalesRecord(27, new DateTime(2021, 05, 13), 300.0, SaleStatus.Pending, s1);
            SalesRecord r28 = new SalesRecord(28, new DateTime(2023, 10, 7), 400.0, SaleStatus.Billed, s3);
            SalesRecord r29 = new SalesRecord(29, new DateTime(2023, 10, 23), 12000.0, SaleStatus.Billed, s5);
            SalesRecord r30 = new SalesRecord(30, new DateTime(2022, 10, 12), 5000.0, SaleStatus.Billed, s2);

            _context.Department.AddRange(d1, d2, d3, d4);

            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);

            _context.SalesRecord.AddRange(
              r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
              r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
              r21, r22, r23, r24, r25, r26, r27, r28, r29, r30
          );
            _context.SaveChanges();
        }
    }
}
