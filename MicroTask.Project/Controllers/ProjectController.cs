﻿using Business;
using Microsoft.AspNetCore.Mvc;
using Steeltoe.Common.Discovery;
using System.Collections.Generic;
using System.Threading.Tasks;
using Common;
using Chloe.MySql;

namespace Controllers
{

    [Route("project")]
    public class ProjectController : Controller
    {

        public ProjectController(IDiscoveryClient client,IProjectService projectService, MySqlContext context)
        {
            this.handler = new DiscoveryHttpClientHandler(client);
            this.projectService = projectService;
        }

        // GET project/values/all
        [HttpPost]
        [Route("all")]
        public async Task<IEnumerable<Project>> Get()
        {
            return null; //new string[] { "value1", "value2" };
        }

        // POST project/edit
        [HttpPost]
        [Route("edit")]
        public void Edit([FromBody]Project project)
        {
            if (project.Id.IsNullOrEmpty())
            {
                projectService.AddProject(project);
            }
        }


        // POST project/{id}
        [HttpGet]
        [Route("{id}")]
        public Project GetProject(string id)
        {
            var project = projectService.GetProjectById(id);

            return project;
        }


        private readonly DiscoveryHttpClientHandler handler;
        private readonly IProjectService projectService;
        private readonly MySqlContext sqlContext;

    }

}
