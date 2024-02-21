using Microsoft.AspNetCore.Mvc;
using Mobil_Market.Models;
using Mobil_Market.Models.IRepositry;
using Mobile_Market.Models;
using Mobile_Market.Models.DBwork;
using System.Collections;

namespace Suq_com.Controllers
{
    public class MemberController : Controller
    {
        private readonly dbcontext dbcontext;

        private readonly IRepositryDBcontext<Member> _repositryDBcontext;

        public MemberController(dbcontext _dbcontext , IRepositryDBcontext<Member> repositryDBcontext)
        {
            dbcontext = _dbcontext;
            _repositryDBcontext= repositryDBcontext;
        }

        private string saveid;
        // this FUNCTION for create random password compone of ( A - To > Z ) &  ( 0 - To - 9 )

        public string CreateRandomPassword()
        {
            char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'R', 'T', 'Y', 'I', 'W', 'Q', 'U', 'I', 'O', 'P', 'S', 'Z', 'X', 'C', 'V', 'N', 'M' };
            char[] chars = new char[9];
            string pass = "";
            Random random = new Random();
        next:
            for (int i = 0; i < 9; i++)
            {
                chars[i] = arr[random.Next(0, arr.Length)];
                pass += chars[i].ToString();
            }

            var passDB = dbcontext.members.Find(pass);
            var mar = passDB;

            if (passDB == null)
                return pass;
            else
                goto next;
        }


        // GET: MemberController
        public ActionResult Index()
        {
            var arr = dbcontext.members.ToList();
            return View(arr);
        }

        //  GET: MemberController/Details/5


        public ActionResult SignIn(string id)
        {
           return  Details(id);
        }

        public ActionResult Details(string id)
        {
            if (ModelState.IsValid)
            {
                var arr = _repositryDBcontext.Get(id);
                return View(arr);
            }
            else
                return View();
        }


        public ActionResult testdatails()
        {

            return View();
        }

        public ActionResult Dashboard()
        {
            return View();
        }

        // GET: MemberController/Create
        public ActionResult Create()
        {
            return View();
            //Member member = new Member();
            //var newid = CreateRandomPassword();

            //return View(member.memberId=newid);
            //var pass = CreateRandomPassword();
            ////dbcontext.members.Add(new Member
            ////{
            ////    memberId = pass
            ////    //firstname = collection.firstname,
            ////    //lastname = collection.lastname,
            ////    //Password = collection.Password,
            ////    //email = collection.email,
            ////    //Gender = collection.Gender,
            ////    //Bdate = collection.Bdate,
            ////    //phone = collection.phone,
            ////    //questionsecurte = collection.questionsecurte
            ////});
            //return View(new Member { memberId=pass});
        }

        // POST: MemberController/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Member collection)
        {
            var newid = CreateRandomPassword();
            try
            {
                if (collection.memberId == "admin") newid = "admin";
                saveid = newid;
                dbcontext.members.Add(new Member
                {
                    memberId =newid,
                    firstname= collection.firstname,
                    lastname= collection.lastname,
                    Gender=collection.Gender,
                    Bdate=collection.Bdate,
                    email=collection.email,
                    phone=collection.phone,
                    Password=collection.Password,
                    questionsecurte=collection.questionsecurte
                });
                dbcontext.SaveChanges();
                var userid = newid;
                return RedirectToAction(nameof(Details), new {id = newid});
            

            }
            catch
            {
                return View();
            }
        }

        public ActionResult detailsPortiflio(string id)
        {
           var obj=  _repositryDBcontext.Get(id);
            return View(obj);
        }



        public string returnidforuser(string? id)
        {
            string message = "Save this ID = {id}  becouse this used in signin";
            System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();
            stringBuilder.Append("<script type = 'text/javascript>'");
            stringBuilder.Append("window.onload=function(){");
            stringBuilder.Append("alert('");
            stringBuilder.Append(message);
            stringBuilder.Append("')};");
            stringBuilder.Append("</script>");

            return "";
        }



        // GET: MemberController/Edit/5
        public ActionResult Edit(string id)
        {
            var arr=dbcontext.members.Find(id);
            return View(arr);
        }

        // POST: MemberController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Member obj)
        {
            try
            {
                dbcontext.members.Update(obj);
                return RedirectToAction(nameof(Details), new { id = obj.memberId });
            }
            catch
            {
                return View();
            }
        }

        // GET: MemberController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MemberController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
