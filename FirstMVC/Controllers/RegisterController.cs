using FirstMVC.ModelHelp;
using FirstMVC.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using first.Tool;


namespace FirstMVC.Controllers
{
    public class RegisterController : Controller
    {
        //
        // GET: /Register/

        public ActionResult Register()
        {
            return View();
        }
        public ActionResult Home()
        {
            return RedirectToActionPermanent("LoginAccess1", new { id = 2 });
           // return View();
        }
      
        //public ActionResult LoginAccess(string recommand = "", string season = "",string q="")
        //{
        //    ViewBag.season = season;
        //    if (q != "")
        //    {
        //        string txt = "select * from Farm where name like'%'+@name+'%'";
        //        SqlParameter[] paramer ={           
        //        new SqlParameter("name",q),                                   
        //                                };
        //        DataTable table = SQLHELP.GetData2(txt, paramer);
        //        List<Farm> ListFarm = new List<Farm>();
        //        DataTable r = SQLHELP.GetRow();
        //        List<Farm> ListRow = new List<Farm>();
        //        foreach (DataRow row in table.Rows)
        //        {
        //            Farm f = new Farm();
        //            f.name = row["name"].ToString();
        //            f.category = row["category"].ToString();
        //            f.belong = row["belong"].ToString();
        //            f.pay = row["pay"].ToString();
        //            f.season = row["season"].ToString();
        //            f.ID = (int)row["ID"];
        //            ListFarm.Add(f);
        //        }
        //        ViewBag.ListFarm = ListFarm;
        //        foreach (DataRow row in r.Rows)
        //        {
        //            Farm f = new Farm();
        //            f.season = row["season"].ToString();
        //            ListRow.Add(f);
        //        }
        //        var allseason = ListRow;
        //        ViewBag.SeasonList = ListRow;
        //    }
        //    else if (season != "")
        //    {
        //        string txt = "select * from Farm where season=@season";
        //        SqlParameter[] paramer ={           
        //        new SqlParameter("season",season),                                   
        //                                };
        //        DataTable table = SQLHELP.GetData2(txt, paramer);
        //        List<Farm> ListFarm = new List<Farm>();
        //        DataTable r = SQLHELP.GetRow();
        //        List<Farm> ListRow = new List<Farm>();
        //        foreach (DataRow row in table.Rows)
        //        {
        //            Farm f = new Farm();
        //            f.name = row["name"].ToString();
        //            f.category = row["category"].ToString();
        //            f.belong = row["belong"].ToString();
        //            f.pay = row["pay"].ToString();
        //            f.season = row["season"].ToString();
        //            f.ID = (int)row["ID"];
        //            ListFarm.Add(f);
        //        }
        //        ViewBag.ListFarm = ListFarm;
        //        foreach (DataRow row in r.Rows)
        //        {
        //            Farm f = new Farm();
        //            f.season = row["season"].ToString();
        //            ListRow.Add(f);
        //        }
        //        var allseason = ListRow;
        //        ViewBag.SeasonList = ListRow;

        //    }
        //    else if (recommand != "")
        //    {
        //        string txt = "select * from Farm where recommand=@recommand";
        //        SqlParameter[] paramer ={           
        //        new SqlParameter("recommand",recommand),                                   
        //                                };
        //        DataTable table = SQLHELP.GetData2(txt, paramer);
        //        List<Farm> ListFarm = new List<Farm>();
        //        DataTable r = SQLHELP.GetRow();
        //        List<Farm> ListRow = new List<Farm>();
        //        foreach (DataRow row in table.Rows)
        //        {
        //            Farm f = new Farm();
        //            f.name = row["name"].ToString();
        //            f.category = row["category"].ToString();
        //            f.belong = row["belong"].ToString();
        //            f.pay = row["pay"].ToString();
        //            f.season = row["season"].ToString();
        //            f.ID = (int)row["ID"];
        //            ListFarm.Add(f);
        //        }
        //        ViewBag.ListFarm = ListFarm;
        //        foreach (DataRow row in r.Rows)
        //        {
        //            Farm f = new Farm();
        //            f.season = row["season"].ToString();
        //            ListRow.Add(f);
        //        }
        //        var allseason = ListRow;
        //        ViewBag.SeasonList = ListRow;
        //    }
        //    else
        //    {
        //        DataTable table = SQLHELP.GetData();
        //        List<Farm> ListFarm = new List<Farm>();
        //        DataTable r = SQLHELP.GetRow();
        //        List<Farm> ListRow = new List<Farm>();
        //        foreach (DataRow row in table.Rows)
        //        {
        //            Farm f = new Farm();
        //            f.name = row["name"].ToString();
        //            f.category = row["category"].ToString();
        //            f.belong = row["belong"].ToString();
        //            f.pay = row["pay"].ToString();
        //            f.season = row["season"].ToString();
        //            f.ID = (int)row["ID"];
        //            ListFarm.Add(f);
        //        }
        //        ViewBag.ListFarm = ListFarm;
        //        foreach (DataRow row in r.Rows)
        //        {
        //            Farm f = new Farm();
        //            f.season = row["season"].ToString();
        //            ListRow.Add(f);
        //        }
        //        var allseason = ListRow;
        //        ViewBag.SeasonList = ListRow;
        //    }
        //    return View();
        //}
      
        public ActionResult Add()
        {
            //return RedirectToAction("Register1", new { id= 2})
            return View();
        }

        public ActionResult Hours()
        {
            string txt = "select * from Hours";
            DataTable table = SQLHELP.GetRow20(txt);
            List<Hours> listhour = new List<Hours>();
            foreach (DataRow row in table.Rows) {
                Hours hour = new Hours();
                hour.dayofweek = (int)row["dayofweek"];
                hour.ID = (int)row["ID"];
                hour.starttime = row["starttime"].ToString();
                hour.endtime = row["endtime"].ToString();
                listhour.Add(hour);
            }
            ViewBag.Hours = listhour;
            return View();
        }

        [HttpGet]
        public ActionResult Category()
        {       
            DataTable table = SQLHELP.GetRow0();
            List<Farm> ListRow=new List<Farm>();
            foreach (DataRow row in table.Rows) {
                Farm f = new Farm();
                f.category = row["category"].ToString();
                f.ID = (int)row["ID"];
                ListRow.Add(f);   
            }           
            ViewBag.ListCategory = ListRow;
            return View();
        }


        [HttpPost]
        public ActionResult Category(string test="") { return View(); }

        public ActionResult TLoginAccess(SearchModel model)
        {
            ViewBag.season = model.season;
            ViewBag.q = model.q;
            ViewBag.recommand = model.recommand;
            // List<Farm> ListRow = new List<Farm>();
            List<String> ListRow = new List<String>();
            model.BackUrl = Request.Url.AbsolutePath
                       + "?season=" + model.season
                       + "&q=" + model.q
                       + "&recommand=" + model.recommand;
            ViewBag.BackUrl = model.BackUrl;
            if (model.season != null)
            {
                string txt = "select * from Farm where season=@season";
                SqlParameter[] paramer ={           
                new SqlParameter("season",model.season),                                   
                                        };
                DataTable table = SQLHELP.GetData2(txt, paramer);
                List<Farm> ListFarm = new List<Farm>();
                DataTable r = SQLHELP.GetRow();
                foreach (DataRow row in table.Rows)
                {
                    Farm f = new Farm();
                    f.name = row["name"].ToString();
                    f.category = row["category"].ToString();
                    f.belong = row["belong"].ToString();
                    f.pay = row["pay"].ToString();
                    f.season = row["season"].ToString();
                    f.ID = (int)row["ID"];
                    ListFarm.Add(f);
                }
                ViewBag.ListFarm = ListFarm;
                foreach (DataRow row in r.Rows)
                {
                    ListRow.Add(row["season"].ToString());
                }
                var allseason = ListRow;

            }
               // dataTable1.Columns.Contains(列名称); 
            else if (model.recommand != null&&model.recommand !="")
            {
                string txt = "select * from Farm where recommand=@recommand";
                SqlParameter[] paramer ={           
                new SqlParameter("recommand",model.recommand),                                   
                                        };
                DataTable table = SQLHELP.GetData2(txt, paramer);
                List<Farm> ListFarm = new List<Farm>();
                DataTable r = SQLHELP.GetRow();
                foreach (DataRow row in table.Rows)
                {
                    Farm f = new Farm();
                    f.name = row["name"].ToString();
                    f.category = row["category"].ToString();
                    f.belong = row["belong"].ToString();
                    f.pay = row["pay"].ToString();
                    f.season = row["season"].ToString();
                    f.ID = (int)row["ID"];
                    ListFarm.Add(f);
                }
                ViewBag.ListFarm = ListFarm;
                foreach (DataRow row in r.Rows)
                {
                    ListRow.Add(row["season"].ToString());
                }
                var allseason = ListRow;
            }
            else if (model.q != null)
            {
                string txt = "select * from Farm where name like'%'+@name+'%'";
                SqlParameter[] paramer ={           
                new SqlParameter("name",model.q),                                   
                                        };
                DataTable table = SQLHELP.GetData2(txt, paramer);
                List<Farm> ListFarm = new List<Farm>();
                DataTable r = SQLHELP.GetRow();
                foreach (DataRow row in table.Rows)
                {
                    Farm f = new Farm();
                    f.name = row["name"].ToString();
                    f.category = row["category"].ToString();
                    f.belong = row["belong"].ToString();
                    f.pay = row["pay"].ToString();
                    f.season = row["season"].ToString();
                    f.ID = (int)row["ID"];
                    ListFarm.Add(f);
                }
                ViewBag.ListFarm = ListFarm;
                foreach (DataRow row in r.Rows)
                {
                    ListRow.Add(row["season"].ToString());

                }
                var allseason = ListRow;
                //return View();
            }
            else
            {
                var a = model.recommand;
                DataTable table = SQLHELP.GetData();
                List<Farm> ListFarm = new List<Farm>();
                DataTable r = SQLHELP.GetRow();
                foreach (DataRow row in table.Rows)
                {
                    Farm f = new Farm();
                    f.name = row["name"].ToString();
                    f.category = row["category"].ToString();
                    f.belong = row["belong"].ToString();
                    f.pay = row["pay"].ToString();
                    f.season = row["season"].ToString();
                    f.ID = (int)row["ID"];
                    ListFarm.Add(f);
                }
                ViewBag.ListFarm = ListFarm;
                foreach (DataRow row in r.Rows)
                {
                    ListRow.Add(row["season"].ToString());
                }
                var allseason = ListRow;
            }
            ViewBag.SeasonList = new SelectList(ListRow, "All");
            return View();
        }
      
        //public ActionResult LoginAccess(string recommand = "", string season = "", string q = "")
        //{
        //    ViewBag.season = season;
        //    ViewBag.q = q;
        //    // List<Farm> ListRow = new List<Farm>();
        //    List<String> ListRow = new List<String>();
        //    // model.BackUrl = Request.Url.AbsolutePath
        //    //+ "?CategoryId=" + model.CategoryId
        //    //+ "&k=" + model.k
        //    //+ "&IsRecommended=" + model.IsRecommended
        //    //+ "&IsPutaway=" + model.IsPutaway
        //    //+ "&page=" + model.page.Value;
        //    if (season != "")
        //    {
        //        string txt = "select * from Farm where season=@season";
        //        SqlParameter[] paramer ={           
        //        new SqlParameter("season",season),                                   
        //                                };
        //        DataTable table = SQLHELP.GetData2(txt, paramer);
        //        List<Farm> ListFarm = new List<Farm>();
        //        DataTable r = SQLHELP.GetRow();
        //        foreach (DataRow row in table.Rows)
        //        {
        //            Farm f = new Farm();
        //            f.name = row["name"].ToString();
        //            f.category = row["category"].ToString();
        //            f.belong = row["belong"].ToString();
        //            f.pay = row["pay"].ToString();
        //            f.season = row["season"].ToString();
        //            f.ID = (int)row["ID"];
        //            ListFarm.Add(f);
        //        }
        //        ViewBag.ListFarm = ListFarm;
        //        foreach (DataRow row in r.Rows)
        //        {
        //            ListRow.Add(row["season"].ToString());
        //        }
        //        var allseason = ListRow;

        //    }
        //    else if (recommand != "")
        //    {
        //        string txt = "select * from Farm where recommand=@recommand";
        //        SqlParameter[] paramer ={           
        //        new SqlParameter("recommand",recommand),                                   
        //                                };
        //        DataTable table = SQLHELP.GetData2(txt, paramer);
        //        List<Farm> ListFarm = new List<Farm>();
        //        DataTable r = SQLHELP.GetRow();
        //        foreach (DataRow row in table.Rows)
        //        {
        //            Farm f = new Farm();
        //            f.name = row["name"].ToString();
        //            f.category = row["category"].ToString();
        //            f.belong = row["belong"].ToString();
        //            f.pay = row["pay"].ToString();
        //            f.season = row["season"].ToString();
        //            f.ID = (int)row["ID"];
        //            ListFarm.Add(f);
        //        }
        //        ViewBag.ListFarm = ListFarm;
        //        foreach (DataRow row in r.Rows)
        //        {
        //            ListRow.Add(row["season"].ToString());
        //        }
        //        var allseason = ListRow;
        //    }
        //    else if (q != "")
        //    {
        //        string txt = "select * from Farm where name like'%'+@name+'%'";
        //        SqlParameter[] paramer ={           
        //        new SqlParameter("name",q),                                   
        //                                };
        //        DataTable table = SQLHELP.GetData2(txt, paramer);
        //        List<Farm> ListFarm = new List<Farm>();
        //        DataTable r = SQLHELP.GetRow();
        //        foreach (DataRow row in table.Rows)
        //        {
        //            Farm f = new Farm();
        //            f.name = row["name"].ToString();
        //            f.category = row["category"].ToString();
        //            f.belong = row["belong"].ToString();
        //            f.pay = row["pay"].ToString();
        //            f.season = row["season"].ToString();
        //            f.ID = (int)row["ID"];
        //            ListFarm.Add(f);
        //        }
        //        ViewBag.ListFarm = ListFarm;
        //        foreach (DataRow row in r.Rows)
        //        {
        //            ListRow.Add(row["season"].ToString());

        //        }
        //        var allseason = ListRow;
        //        //return View();
        //    }
        //    else
        //    {
        //        DataTable table = SQLHELP.GetData();
        //        List<Farm> ListFarm = new List<Farm>();
        //        DataTable r = SQLHELP.GetRow();
        //        foreach (DataRow row in table.Rows)
        //        {
        //            Farm f = new Farm();
        //            f.name = row["name"].ToString();
        //            f.category = row["category"].ToString();
        //            f.belong = row["belong"].ToString();
        //            f.pay = row["pay"].ToString();
        //            f.season = row["season"].ToString();
        //            f.ID = (int)row["ID"];
        //            ListFarm.Add(f);
        //        }
        //        ViewBag.ListFarm = ListFarm;
        //        foreach (DataRow row in r.Rows)
        //        {
        //            ListRow.Add(row["season"].ToString());
        //        }
        //        var allseason = ListRow;
        //    }
        //    ViewBag.SeasonList = new SelectList(ListRow, season);
        //    return View();
        //}     

        public ActionResult LoginAccess1(SearchModel model)
        {
            ViewBag.season = model.season;
            ViewBag.q = model.q;
            ViewBag.recommand = model.recommand;
            // List<Farm> ListRow = new List<Farm>();
            List<String> ListRow = new List<String>();
            model.BackUrl = Request.Url.AbsolutePath
                       + "?season=" + model.season
                       + "&q=" + model.q
                       + "&recommand=" + model.recommand;
            ViewBag.BackUrl = model.BackUrl;
            if (model.season != null)
            {
                string txt = "select * from Farm where season=@season";
                SqlParameter[] paramer ={           
                new SqlParameter("season",model.season),                                   
                                        };
                DataTable table = SQLHELP.GetData2(txt, paramer);
                List<Farm> ListFarm = new List<Farm>();
                DataTable r = SQLHELP.GetRow();
                foreach (DataRow row in table.Rows)
                {
                    Farm f = new Farm();
                    f.name = row["name"].ToString();
                    f.category = row["category"].ToString();
                    f.belong = row["belong"].ToString();
                    f.pay = row["pay"].ToString();
                    f.season = row["season"].ToString();
                    f.ID = (int)row["ID"];
                    ListFarm.Add(f);
                }
                ViewBag.ListFarm = ListFarm;
                foreach (DataRow row in r.Rows)
                {
                    ListRow.Add(row["season"].ToString());
                }
                var allseason = ListRow;

            }
            else if (model.recommand != null && model.recommand != "")
            {
                string txt = "select * from Farm where recommand=@recommand";
                SqlParameter[] paramer ={           
                new SqlParameter("recommand",model.recommand),                                   
                                        };
                DataTable table = SQLHELP.GetData2(txt, paramer);
                List<Farm> ListFarm = new List<Farm>();
                DataTable r = SQLHELP.GetRow();
                foreach (DataRow row in table.Rows)
                {
                    Farm f = new Farm();
                    f.name = row["name"].ToString();
                    f.category = row["category"].ToString();
                    f.belong = row["belong"].ToString();
                    f.pay = row["pay"].ToString();
                    f.season = row["season"].ToString();
                    f.ID = (int)row["ID"];
                    ListFarm.Add(f);
                }
                ViewBag.ListFarm = ListFarm;
                foreach (DataRow row in r.Rows)
                {
                    ListRow.Add(row["season"].ToString());
                }
                var allseason = ListRow;
            }
            else if (model.q != null)
            {
                string txt = "select * from Farm where name like'%'+@name+'%'";
                SqlParameter[] paramer ={           
                new SqlParameter("name",model.q),                                   
                                        };
                DataTable table = SQLHELP.GetData2(txt, paramer);
                List<Farm> ListFarm = new List<Farm>();
                DataTable r = SQLHELP.GetRow();
                foreach (DataRow row in table.Rows)
                {
                    Farm f = new Farm();
                    f.name = row["name"].ToString();
                    f.category = row["category"].ToString();
                    f.belong = row["belong"].ToString();
                    f.pay = row["pay"].ToString();
                    f.season = row["season"].ToString();
                    f.ID = (int)row["ID"];
                    ListFarm.Add(f);
                }
                ViewBag.ListFarm = ListFarm;
                foreach (DataRow row in r.Rows)
                {
                    ListRow.Add(row["season"].ToString());

                }
                var allseason = ListRow;
                //return View();
            }
            else
            {
                var a = model.recommand;
                DataTable table = SQLHELP.GetData();
                List<Farm> ListFarm = new List<Farm>();
                DataTable r = SQLHELP.GetRow();
                foreach (DataRow row in table.Rows)
                {
                    Farm f = new Farm();
                    f.name = row["name"].ToString();
                    f.category = row["category"].ToString();
                    f.belong = row["belong"].ToString();
                    f.pay = row["pay"].ToString();
                    f.season = row["season"].ToString();
                    f.ID = (int)row["ID"];
                    ListFarm.Add(f);
                }
                ViewBag.ListFarm = ListFarm;
                foreach (DataRow row in r.Rows)
                {
                    ListRow.Add(row["season"].ToString());
                }
                var allseason = ListRow;
            }
            ViewBag.SeasonList = new SelectList(ListRow, "spring");
            return View();
        }
        public ActionResult AddItem(string name, string category, string season, string belong, string pay, bool  recommand)
        {
            Farm f = new Farm();
            f.name = name;
            f.category = category;
            f.season = season;
            f.belong = belong;
            f.pay = pay;
            f.recommand = recommand;
            string text = "insert into Farm (name,category,season,belong,pay,recommand)values(@name,@category,@season,@belong,@pay,@recommand)";
            SqlParameter[] paramer ={
                new SqlParameter("name",f.name),
                new SqlParameter("category",f.category),
                new SqlParameter("season",f.season),
                new SqlParameter("belong",f.belong),
                new SqlParameter("pay",f.pay),
                new SqlParameter("recommand",f.recommand),
                                    };
            SQLHELP.ExecuteSql(text, paramer);
            return Content("sdfsdf");
        }

        public ActionResult TestResult(string name)
        {
            return Content(name+" ok");
        }

        public ActionResult ChangeRecommend(bool isChecked,int? id=null )
        {
            Farm f = new Farm();
            f.ID = (int)id;
            f.recommand = isChecked;
            string text = "update Farm set recommand=@recommand where id=@ID";
            SqlParameter[] paramer ={
            new SqlParameter("ID",f.ID),
            new SqlParameter("recommand",f.recommand),                                    };
            SQLHELP.ExecuteSql(text, paramer);
            return Content("ok");
        }
        [HttpGet]
        public ActionResult Edit(int ID, string backUrl="")
        {
            ViewBag.BackUrl = backUrl;
            string txt = "select* from product where ID=@ID";
            SqlParameter[] paramer ={           
                new SqlParameter("ID",ID),                                   
                                     };
            DataTable table = SQLHELP.GetData2(txt, paramer);
            product p = new product();
            p.thumbnail = table.Rows[0]["Thumbnail"].ToString();
            p.category = table.Rows[0]["category"].ToString();
            p.description1 = table.Rows[0]["description"].ToString();
            p.ID = table.Rows[0]["ID"].ToString();
            p.isrecommand = Convert.ToBoolean(table.Rows[0]["isrecommand"]);
            p.name = table.Rows[0]["name"].ToString();
            return View(p);
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(product model)
        {
            //var files = Request.Files;
            var product = new product();
            product.ID = model.ID;
            product.name = model.name;
            product.isrecommand = model.isrecommand;
            product.category = model.category;
            product.description = model.description1;
            product.thumbnail = model.thumbnail;          
            string text = "update product set name=@name,description=@description,isrecommand=@isrecommand where ID=@ID";
            SqlParameter[] paramer ={
                new SqlParameter("name",product.name),
                new SqlParameter("description",product.description),
                new SqlParameter("isrecommand",product.isrecommand),
                new SqlParameter("ID",product.ID),
                                     };
            SQLHELP.ExecuteSql(text, paramer);
            return View(product);
        }
   
        public ActionResult Photos(int ID)
        {
            string txt = "select Thumbnail from Farm where ID=@ID";
            SqlParameter[] paramer ={           
                new SqlParameter("ID",ID),                                   
                                     };
            DataTable table = SQLHELP.GetData2(txt, paramer);
            List<Farm> ListFarm = new List<Farm>();
            foreach (DataRow row in table.Rows)
            {
                Farm f = new Farm();
                f.Thumbnail = (string)row["Thumbnail"];
                ListFarm.Add(f);
            }
            ViewBag.ProductPhoto = ListFarm;
            return View();
        }

        //public ActionResult LoginAccess(string recommand = "",string season="")
        //{
        //    if (recommand == "")
        //    {
        //        DataTable table = SQLHELP.GetData();
        //        List<Farm> ListFarm = new List<Farm>();
        //        DataTable r = SQLHELP.GetRow();
        //        List<Farm> ListRow = new List<Farm>();
        //        foreach (DataRow row in table.Rows)
        //        {
        //            Farm f = new Farm();
        //            f.name = row["name"].ToString();
        //            f.category = row["category"].ToString();
        //            f.belong = row["belong"].ToString();
        //            f.pay = row["pay"].ToString();
        //            f.season = row["season"].ToString();
        //            f.ID = (int)row["ID"];
        //            ListFarm.Add(f);
        //        }
        //        ViewBag.ListFarm = ListFarm;
        //        foreach (DataRow row in r.Rows)
        //        {
        //            Farm f = new Farm();
        //            f.season = row["season"].ToString();
        //            ListRow.Add(f);
        //        }
        //        var allseason = ListRow;
        //        ViewBag.SeasonList = new SelectList(allseason, "ID", "season");
        //    }
    }
}
