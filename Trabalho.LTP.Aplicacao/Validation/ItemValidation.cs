using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho.LTP.Dominio.ItensRoot;

namespace Trabalho.LTP.Aplicacao.Validation
{
    public class ItemValidation : AbstractValidator<Item>
    {
        public ItemValidation()
        {
            RuleFor(a => a.Nome)
                .NotEmpty().WithMessage("O campo {PropertyName} é obrigatório.")
                .Length(2, 150).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres.");

            RuleFor(a => a.Descricao)
                .NotEmpty().WithMessage("O Campo {PropertyName} é obrigatório.")
                .Length(2, 150).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres.");

            RuleFor(a => a.Preco)
                .NotEmpty().WithMessage("O campo {PropertyName} é obrigatório.");


            RuleFor(a => a.Quantidade)
                .NotEmpty().WithMessage("O campo {PropertyName} é obrigatório.");
            
        }
    }
}
