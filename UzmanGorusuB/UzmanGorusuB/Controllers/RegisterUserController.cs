using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Net.Sockets;
using UzmanGorusuB.Models;

namespace UzmanGorusuB.Controllers
{
    [AllowAnonymous]
    public class RegisterUserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _rolmanager;
   
        Context c = new Context();

        public RegisterUserController(UserManager<AppUser> userManager, RoleManager<AppRole> rolmanager)
        {
            _userManager = userManager;
            _rolmanager = rolmanager;

        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserSignUpViewModel p)
        {


            if (ModelState.IsValid)


            {
               
                AppUser user = new AppUser()
                {
                    Email = p.Mail,
                    UserName = p.UserName,
                    NameSurname = p.nameSurname,
                    SelectRole = p.UserRole


                };
               
                var result = await _userManager.CreateAsync(user,p.Password);
                if (result.Succeeded)
                {
                    var userid=user.Id;
                    var AppUserRole = new AppUserRole()
                    {
                        RoleId= p.UserRole,
                        UserId = userid

                    };
                    //  var reult = await _rolmanager.CreateAsync(AppUserRole);

                    List<AppRole> allRoles = _rolmanager.Roles.ToList();
                //    if (p.UserRole==3)
                 //   await _userManager.AddToRoleAsync(user, );
                    if (p.UserRole == 1002){
                        await _userManager.AddToRoleAsync(user, "APPLICANTEXPERT");
                     //   await _userManager.AddToRoleAsync(user, "EXPERT");

                    }
                          

                }
             
                if (result.Succeeded) 
                    if(p.UserRole== 0)
                    {

                        var applicant = new Applicant()
                        {
                            ApplicantMail = p.Mail,
                            ApplicantName = p.UserName,
                            ApplicantPassword = p.Password
                        };
                        c.Applicants.Add(applicant);
                        await c.SaveChangesAsync();
                    }else if(p.UserRole== 1)
                    {
                        var expert = new ApplicantExpert()
                        {
                            ApplicantExpertName = p.UserName,
                            ApplicantExpertMail = p.Mail
                        };
                        c.ApplicantExperts.Add(expert);
                        c.SaveChanges();
                    }
                
                else
                {
                    foreach(var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
                
            }
            return View(p);
        }
    }
}
