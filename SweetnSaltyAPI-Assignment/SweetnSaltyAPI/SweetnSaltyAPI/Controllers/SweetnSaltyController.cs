using System;
using Microsoft.AspNetCore.Mvc;
using SweetnSaltyBusiness;
using SweetnSaltyModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SweetnSaltyAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class SweetnSaltyController : Controller
    {
        private readonly ISweetnSaltyBusinessClass _businessClass;


        //constructor
        public SweetnSaltyController(ISweetnSaltyBusinessClass ISweetnSaltyBusinessClass)
        {
            _businessClass = ISweetnSaltyBusinessClass;
        }


        [HttpPost]
        [Route("postaflavor/{Flavor Name:}")]
       
        public async Task<ActionResult<Flavor>> PostFlavor(string flavor_Name)
        {
            //call to the business layer and send a string

            Flavor getflavor = await _businessClass.PostFlavor(flavor_Name);
            if (getflavor != null)
            {
               
                return Created($"http://5001/sweetnsalty/postaflavor/{getflavor.flavor_Id}", getflavor);
            }
            else
            {
                return BadRequest();
            }


        }

        [HttpPost]
        [Route("postaperson/{person_FName}/{person_LName}")]
        public async Task<ActionResult<Person>> PostPerson(string person_FName, string person_LName)
        {
            Person postPerson = await _businessClass.PostPerson(person_FName, person_LName);
            if (postPerson != null)
            {

                return Created($"http://5001/sweetnsalty/postaPerson/{postPerson.person_FName}/{postPerson.person_LName}", postPerson);
            }
            else
            {
                return BadRequest();
            }

        }

        [HttpGet]
        [Route("getaperson/{person_FName}/{person_LName}")]
        public async Task<ActionResult<Person>> GetPerson(string person_FName, string person_LName)
        {
            Person getPerson = await _businessClass.GetPerson(person_FName, person_LName);
            if (getPerson != null)
            {

                return Created($"http://5001/sweetnsalty/getaPerson/{getPerson.person_FName}/{getPerson.person_LName}", getPerson);
            }
            else
            {
                return BadRequest();
            }
        }

        //[HttpGet]
        //[Route("getapersonandflavors")]
        //public async Task<Person> GetPersonFavFlavor(int id)
        //{
        //    throw new NotImplementedException();

        //}

        [HttpGet]
        [Route("getlistofflavors")]
        public async Task<List<Flavor>> GetFlavors()
        {
            throw new NotImplementedException();

        }



    }
}
