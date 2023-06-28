using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureesController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insurees
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insurees/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insurees/Create

        //1. In the InsureeController, add logic to calculate a quote based on these guidelines: 

        //A.Start with a base of $50 / month.
        //B.If the user is 18 or under, add $100 to the monthly total.
        //C.If the user is from 19 to 25, add $50 to the monthly total.
        //D.If the user is 26 or older, add $25 to the monthly total. Double check your code to ensure all ages are covered.
        //E.If the car's year is before 2000, add $25 to the monthly total.
        //F.If the car's year is after 2015, add $25 to the monthly total.
        //G.If the car's Make is a Porsche, add $25 to the price.
        //H.If the car's Make is a Porsche and its model is a 911 Carrera, add an additional $25 to the price. (Meaning, this specific car will add a total of $50 to the price.)
        //I.Add $10 to the monthly total for every speeding ticket the user has.
        //J.If the user has ever had a DUI, add 25% to the total.
        //K.If it's full coverage, add 50% to the total.

        //2.Modify the Create View so that the user does not see the “Quote” input field.
            //I added @* ----- *@ around the "Quote" div form group on the Create Page.

        //3.Add an Admin View for a site administrator to the Insuree Views. This page must show all quotes issued, along with the user's first name, last name, and email address.


        public ActionResult Create()
        {
            return View();
        }

        // POST: Insurees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                //A. Start with a base of $50 / month.
                insuree.Quote = 50;

                int age = DateTime.Now.Year - insuree.DateOfBirth.Year;
                //B. If the user is 18 or under, add $100 to the monthly total.
                if (age <= 18)
                {
                    insuree.Quote = insuree.Quote + 100;
                }
                //C. If the user is from 19 to 25, add $50 to the monthly total.
                if (age >= 19 || age <= 25)
                {
                    insuree.Quote = insuree.Quote + 50;
                }
                //D. If the user is 26 or older, add $25 to the monthly total. Double check your code to ensure all ages are covered.
                if (age >= 26)
                {
                    insuree.Quote = insuree.Quote + 25;
                }

                //E. If the car's year is before 2000, add $25 to the monthly total.
                //F. If the car's year is after 2015, add $25 to the monthly total.
                if (insuree.CarYear <= 2000 || insuree.CarYear >= 2015)
                {
                    insuree.Quote = insuree.Quote + 25;
                }

                //G. If the car's Make is a Porsche, add $25 to the price.
                if (insuree.CarMake == "Porsche" || insuree.CarMake == "porsche")
                {
                    insuree.Quote = insuree.Quote + 25;
                }
                //H. If the car's Make is a Porsche and its model is a 911 Carrera, add an additional $25 to the price. (Meaning, this specific car will add a total of $50 to the price.)
                if (insuree.CarMake == "Porsche" || insuree.CarMake == "porsche" && insuree.CarModel == "911 Carrera" || insuree.CarModel == "911 carrera")
                {
                    insuree.Quote = insuree.Quote + 25;
                }

                //I. Add $10 to the monthly total for every speeding ticket the user has.
                if (insuree.SpeedingTickets > 0)
                {
                    insuree.Quote = insuree.Quote + (insuree.SpeedingTickets * 10);
                }
                //J. If the user has ever had a DUI, add 25% to the total.
                if (insuree.DUI == true)
                    
                {
                    Decimal dec = .25m;
                    Decimal res = Decimal.Multiply(insuree.Quote, dec);
                    insuree.Quote = insuree.Quote + res;
                }
                //K. If it's full coverage, add 50% to the total.
                if (insuree.CoverageType == true)
                {
                    insuree.Quote = insuree.Quote + (insuree.Quote * .5m);
                }
                    db.Insurees.Add(insuree);
                    db.SaveChanges();
                    return RedirectToAction("Index", insuree);
            }
            return View(insuree);
        }

        //public ActionResult Admin()
        //{
        //    return View();
        //}
        //[HttpPost]
        //[ValidateAntiForgeryToken]

        public ActionResult Admin()
        {
            

            return View(db.Insurees.ToList());
            //using (InsuranceEntities db = new InsuranceEntities())
            //{



            //    var insurees = db.Insurees;
            //    var insureeVms = new List<Insuree>();
            //    foreach (var insuree in insurees)
            //    {
            //        var insureeVm = new Insuree();
            //        insureeVm.FirstName = insuree.FirstName;
            //        insureeVm.LastName = insuree.LastName;
            //        insureeVm.EmailAddress = insuree.EmailAddress;
            //        insureeVms.Add(insureeVm);
            //    }
            //    return View(insureeVms);
            //}
            
        }
        // GET: Insurees/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insurees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insurees/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insurees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
