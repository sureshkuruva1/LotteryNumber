using ExceptionLogger;
using LotteryClient.Entities;
using LotteryClient.Helpers;
using LotteryClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LotteryClient.Controllers
{
    public class NumberSeriesController : Controller
    {
        // GET: NumberSeries
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Generate()
        {
            var lModel = new NumberSeriesModel();
            return View(lModel);
        }

        [HttpPost]
        public ActionResult Generate(NumberSeriesModel model)
        {            
            var lRequest = new NumberSeriesRequest
            {
                SeriesLength = model.SeriesLength,
                NumberMin = model.NumberMin,
                NumberMax = model.NumberMax                
            };
            try
            {
                var lResponse = ServiceHelper.GenerateNumbers(lRequest);
                if (lResponse != null)
                {
                    model.LotteryNumbers = lResponse.NumberSeries;
                    model.NumbersClass = new string[model.LotteryNumbers.Count];

                    int i = 0;
                    foreach (var num in lResponse.NumberSeries)
                    {
                        if (num < 10)
                        {
                            model.NumbersClass[i] = "ten";
                        }
                        else if (num >= 10 && num < 20)
                        {
                            model.NumbersClass[i] = "twenty";
                        }
                        else if (num >= 20 && num < 30)
                        {
                            model.NumbersClass[i] = "thirty";
                        }
                        else if (num >= 30 && num < 40)
                        {
                            model.NumbersClass[i] = "forty";
                        }
                        else if (num >= 40 && num < 50)
                        {
                            model.NumbersClass[i] = "fifty";
                        }
                        else
                        {
                            model.NumbersClass[i] = "noclass";
                        }
                        i++;
                    }
                }
            }
            catch(BusinessException ex)
            {
                ViewBag.ErrMessage = ex.Message;
            }
            catch
            {
                ViewBag.ErrMessage = "Error Generating Numbers";
            }
            
            return View(model);
        }
    }
}