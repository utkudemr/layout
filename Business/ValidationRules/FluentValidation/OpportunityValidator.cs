using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using Weekly.Entities.Concrete;

namespace Business.ValidationRules.FluentValidation
{
    public class OpportunityValidator:AbstractValidator<Opportunity>
    {
        public OpportunityValidator()
        {
            RuleFor(p => p.Acc_Country).NotEmpty().WithMessage("Account Country not selected");
            RuleFor(p => p.Des_Country).NotEmpty().WithMessage("Destination Country not selected");
            RuleFor(p => p.ElepphantProject).NotEmpty().WithMessage("Elephant Project not selected");
            RuleFor(p => p.EndUserSegmentId).NotEmpty().WithMessage("End User Segment not selected");
            RuleFor(p => p.CustomerId).NotEmpty().WithMessage("Customer not selected");
            RuleFor(p => p.OppurtunityNo).NotEmpty();
            RuleFor(p => p.ProjectName).NotEmpty();
            //   RuleFor(p => p.StatusId).NotEmpty().WithMessage("Status not selected");
            RuleFor(p => p.UserId).NotEmpty().WithMessage("User not selected");
        }
    }
}
