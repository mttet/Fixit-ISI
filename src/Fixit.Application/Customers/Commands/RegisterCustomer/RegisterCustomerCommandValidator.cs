﻿using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace Fixit.Application.Customers.Commands.RegisterCustomer
{
  public class RegisterCustomerCommandValidator : AbstractValidator<RegisterCustomerCommand>
  {
    public RegisterCustomerCommandValidator()
    {
      RuleFor(x => x.FirstName)
        .NotNull()
        .NotEmpty();

      RuleFor(x => x.LastName)
        .NotNull()
        .NotEmpty();

      RuleFor(x => x.Email)
        .NotNull()
        .NotEmpty()
        .EmailAddress();

      RuleFor(x => x.Password)
        .NotNull()
        .NotEmpty()
        .Matches("^(((?=.*[a-z])(?=.*[A-Z]))|((?=.*[a-z])(?=.*[0-9]))|((?=.*[A-Z])(?=.*[0-9])))(?=.{6,})");

      RuleFor(x => x.PhoneNumber)
        .NotNull()
        .NotEmpty();
    }
  }
}
