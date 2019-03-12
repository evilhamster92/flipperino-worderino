using FlipperinoWorderino.Contracts.Models;
using FlipperinoWorderino.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;
using AutoMapper;
using ControllerBase = Microsoft.AspNetCore.Mvc.ControllerBase;

namespace FlipperinoWorderino.WebApi
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class WordFlippingController : ControllerBase
    {

        private readonly WordService _wordService;

        public WordFlippingController(WordService wordService)
        {
            _wordService = wordService;
        }

        [System.Web.Mvc.HttpPost]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        public ActionResult<WordResponse> FlipWord(WordRequest word)
        {
            try
            {
                var returnedWord = _wordService.InternalArrayReverse(word);
                WordResponse response = Mapper.Map<WordResponse>(returnedWord);
                return new ActionResult<WordResponse>(response);
            }
            catch (Exception ex)
            {
                return new ActionResult<WordResponse>(new WordResponse());
            }
        }
    }
}
