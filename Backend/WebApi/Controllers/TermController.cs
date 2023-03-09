﻿using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Neo4j.Driver;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public sealed class TermController : ControllerBase
{
    private readonly IDriver _context;

    public TermController(IDriver context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<Results<Ok<Term>, EmptyHttpResult>> GetTerms()
    {
        return TypedResults.Ok(await _context.GetServerInfoAsync());
    }
    
    [HttpPost]
    public async Task<Results<Created<Term>, BadRequest>> CreateTerm()
    {
        
    }
}