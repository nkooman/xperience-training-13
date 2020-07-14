﻿using CMS.DocumentEngine;

using XperienceAdapter;
using XperienceAdapter.Repositories;
using Business.Dtos;

namespace Business.Repositories
{
    public class UrlSlugPageRepository : BasePageRepository<BasicPageWithUrlSlug, TreeNode>
    {
        public UrlSlugPageRepository(IRepositoryDependencies repositoryDependencies) : base(repositoryDependencies)
        {
        }

        public override BasicPageWithUrlSlug MapDtoProperties(TreeNode page, BasicPageWithUrlSlug dto)
        {
            dto.UrlSlug = page.GetStringValue("UrlSlug", default);

            return dto;
        }
    }
}