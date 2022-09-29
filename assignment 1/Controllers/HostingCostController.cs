using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assignment_1.Controllers
{
    // GET api/HostingCost{id = 0}
    // returns 3 strings with the cost of number of fortnights, cost of tax and total cost strings
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// calculates the cost of web hosting and maintenance
        /// </summary>
        /// <param name="id">
        /// number of days that have elapsed since the start of service
        /// </param>
        /// <returns>
        /// description of the total cost of service and tax breakdown
        /// </returns>
        public IEnumerable<string> Get(int id)
        {
            // delcaring constants
            const int daysPerFn = 14;
            const double costPerFn = 5.5;
            const double HST = 0.13;
            //declaring variables
            IEnumerable<string> response;
            string fnResponse;
            string taxResponse;
            string totalReponse;
            double fnCost;
            double fnEstimate;
            int fortNights;
            double taxDue;
            double total;
            
            // calculates fortnight by diving it by 14(days per fornight)
            fnEstimate = (double)id / daysPerFn;
            // remove decimal places and add 1 because 0-14 nights is 1 fortnight
            fortNights = (int)Math.Floor(fnEstimate) + 1;
            //calculate cost of fornights by multiplying number of fornights by cost of fornight
            fnCost = Math.Round(fortNights * costPerFn, 2);
            //calculate the tax by multipling cost of fortnights by the HST rate and rounding it to nearest 2 decimal places
            taxDue = Math.Round(fnCost * HST, 2);
            //calculate total by ading cost of fornights and the calcuated tax of those fortnights
            total = fnCost + taxDue;
            // format response string with calcuated costs
            fnResponse = fortNights + " fortnights at $5.50/FN = " + fnCost.ToString("C") + " CAD";
            taxResponse = "HST 13% = " + taxDue + " CAD";
            totalReponse = "Total = $" + total + " CAD";
            response =  new string[] {fnResponse, taxResponse, totalReponse };
            return response;
        }
    }
}
