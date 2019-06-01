using FluentValidation;
using Modelo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Service.Validators
{
    public class    ClienteValidator : AbstractValidator<Cliente>
    {
        public ClienteValidator()
        {
            RuleFor(c => c)
                .NotNull()
                .OnAnyFailure(x =>
                {
                    throw new ArgumentNullException("Can't found the object.");
                });

            RuleFor(c => c.rgCliente)
                .NotEmpty().WithMessage("E necessario informar o rg.")
                .NotNull().WithMessage("E necessario informar o rg.");

            RuleFor(c => c.nascimentoCLiente)
                .NotEmpty().WithMessage("E necessario informar a data de nascimento.")
                .NotNull().WithMessage("E necessario informar a data de nascimento.");

            RuleFor(c => c.nomeCliente)
                .NotEmpty().WithMessage("E necessario informar o nome.")
                .NotNull().WithMessage("E necessario informar o nome.");

            RuleFor(c => c.enderecoCliente)
                .NotEmpty().WithMessage("E necessario informar o endereco.")
                .NotNull().WithMessage("E necessario informar o endereco.");

            RuleFor(c => c.bairroCliente)
                .NotEmpty().WithMessage("E necessario informar o bairro.")
                .NotNull().WithMessage("E necessario informar o bairro.");

            RuleFor(c => c.cidadeCliente)
                .NotEmpty().WithMessage("E necessario informar a cidade.")
                .NotNull().WithMessage("E necessario informar a cidade.");

            RuleFor(c => c.estadoCLiente)
                .NotEmpty().WithMessage("E necessario informar o estado.")
                .NotNull().WithMessage("E necessario informar o estado.");

            RuleFor(c => c.CEPCLiente)
                .NotEmpty().WithMessage("E necessario informar o CEP.")
                .NotNull().WithMessage("E necessario informar o CEP.");

            RuleFor(c => c.nascimentoCLiente)
                .NotEmpty().WithMessage("E necessario informar o nascimento.")
                .NotNull().WithMessage("E necessario informar o nascimento.");
        }

    }
}
