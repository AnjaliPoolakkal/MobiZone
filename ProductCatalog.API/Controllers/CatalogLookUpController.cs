using Microsoft.AspNetCore.Mvc;
using ProductCatalog.API.Messages;
using ProductCatalog.API.Models;
using ProductCatalog.BusinessObject;
using ProductCatalog.Domain.DataBase;
using ProductCatalog.Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ProductCatalog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogLookUpController : ControllerBase
    {
        private readonly CatalogDBContext _context;
        ICatalogLookUpBO _catalogLookUpBO;
        ResponseModel<LookUp> _response;
        IMessages _lookUpMessages;
        IEnumerable<LookUp> _lookUpList;
        LookUp _lookUpData;

        public CatalogLookUpController(ICatalogLookUpBO catalogLookUpBO,CatalogDBContext context)
        {
            _context = context;
            _catalogLookUpBO = catalogLookUpBO;
            _response = new ResponseModel<LookUp>();
            _lookUpData = new LookUp();
            _lookUpMessages = new MasterMessages();
        }


        #region Post method for masterpage
        /// <summary>
        /// POST: api/CatalogItems
        /// </summary>
        /// <param name="lookUp"></param>
        /// <returns>it returns a json file wich shows response messages</returns>
        [HttpPost]
        public async Task<ActionResult<LookUp>> PostCatalogLookUp(LookUp lookUp)
        {
            ResponseModel<string> _response = new ResponseModel<string>();
            try
            {
                await _catalogLookUpBO.Add(lookUp);
                string message = _lookUpMessages.Added + ", Response Message : " + new HttpResponseMessage(System.Net.HttpStatusCode.OK);
                _response.AddResponse(true, 0, "", message);
                var data = Newtonsoft.Json.JsonConvert.SerializeObject(_response);
                return new JsonResult(_response);
            }
            catch (Exception ex)
            {
                string message =  _lookUpMessages.ExceptionError + ", Response Message : " + new HttpResponseMessage(System.Net.HttpStatusCode.InternalServerError);
                _response.AddResponse(false, 0, _lookUpMessages.ExceptionError, message);
                return new JsonResult(_response);
            }

        }
        #endregion

        #region Get Method for Products
        /// <summary>
        /// GET: api/GetLookUpItems
        /// </summary>
        /// <returns>it returns the data list </returns>
         
        [HttpGet]
        public async Task< ActionResult<IEnumerable<LookUp>>> GetLookUpItems()
        {
           
            try
            {
                _lookUpList = await _catalogLookUpBO.GetLookUpItems();
                if (_lookUpList == null)
                {
                    ResponseModel<string> _response = new ResponseModel<string>();
                    string message = _lookUpMessages.Null + new HttpResponseMessage(System.Net.HttpStatusCode.OK);
                    _response.AddResponse(true, 0, _lookUpMessages.Null, message);
                    return new JsonResult(_response);
                }
                else
                {
                    ResponseModel<IEnumerable<LookUp>> _response = new ResponseModel<IEnumerable<LookUp>>();
                    string message = "" + new HttpResponseMessage(System.Net.HttpStatusCode.OK);
                    _response.AddResponse(true, 0, _lookUpList, message);

                    return new JsonResult(_response);
                }

            }
            catch (Exception ex)
            {
                ResponseModel<string> _response = new ResponseModel<string>();
                string message = _lookUpMessages.ExceptionError + new HttpResponseMessage(System.Net.HttpStatusCode.OK);
                _response.AddResponse(false, 0, _lookUpMessages.ExceptionError, message);

                return new JsonResult(_response);
            }

        }
        #endregion


    }
}
