using FingerprintMatchingEngine.Models;
using FingerprintMatchingEngine.DTO;
using Microsoft.AspNetCore.Mvc;
using FingerprintMatchingEngine.Interface;

namespace FingerprintMatchingEngine.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FingerController : ControllerBase
    {
        private readonly IFingerServices _fingerServices;

        public FingerController(IFingerServices fingerServices)
        {
            _fingerServices = fingerServices;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var fingers = await _fingerServices.GetFingersAsync();
            return Ok(fingers);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var finger = await _fingerServices.GetFingerByIdAsync(id);

            if (finger == null)
            {
                return NotFound();
            }

            return Ok(finger);
        }

        [HttpPost]
        public async Task<IActionResult> Create(NewFingerDTO finger)
        {
            var newfinger = await _fingerServices.AddFingerAsync(finger);
            return CreatedAtAction(nameof(GetById), new { id = newfinger.FingerId }, newfinger);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Finger finger)
        {
            var existingfinger = await _fingerServices.UpdateFingerAsync(id, finger);

            if (existingfinger == null)
            {
                return NotFound();
            }

            return Ok(existingfinger);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _fingerServices.DeleteFingerAsync(id);

            if (!result)
            {
                return NotFound();
            }

            return Ok();
        }
    }
}
