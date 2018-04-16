using System;
using System.Linq;
using System.Data;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Collections.Generic;
using Scaffolding.CustomFilter.Common.Utils;
using Scaffolding.CustomFilter.Common.DataModel;
using Scaffolding.CustomFilter.Common.DataModel.EntityFramework;
using Scaffolding.CustomFilter.Model;

namespace Scaffolding.CustomFilter.IssueContextDataModel {
    public class IssueContextUnitOfWork : DbUnitOfWork<IssueContext>, IIssueContextUnitOfWork {
        Lazy<IIssueRepository> issuesRepository;

        public IssueContextUnitOfWork(IssueContext context)
            : base(context) {
            issuesRepository = new Lazy<IIssueRepository>(() => new IssueRepository(this));
        }
        bool IIssueContextUnitOfWork.HasChanges() {
            return Context.ChangeTracker.HasChanges();
        }
        IIssueRepository IIssueContextUnitOfWork.Issues {
            get { return issuesRepository.Value; }
        }
    }
}
