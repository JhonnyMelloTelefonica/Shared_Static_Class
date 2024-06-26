using Microsoft.Extensions.Options;
using PropertyChanged;
using Shared_Static_Class.Data;
using Shared_Static_Class.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared_Static_Class.Model_DTO
{
    [AddINotifyPropertyChangedInterface]
    public class CreateProdutoDTO : INotifyPropertyChanged
    {
        [MaxLength(255, ErrorMessage = "O Nome do produto tem o máximo de 255 caracteres")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Nome { get; set; } = string.Empty;
        [MaxLength(1200, ErrorMessage = "O Nome do produto tem o máximo de 1200 caracteres")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Descrição { get; set; } = string.Empty;
        [Range(0, 100, ErrorMessage = "A Avaliação tem que estar entre 0 e 100")]
        public int Avaliacao { get; set; } = 0;
        [EnumDataType(typeof(Categoria_Produto), ErrorMessage = "Este valor não é válido para este campo")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public Categoria_Produto Categoria { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Fabricante { get; set; } = string.Empty;
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Cor { get; set; } = string.Empty;
        public bool IsOferta { get; set; } = false;
        public decimal Valor { get; set; } = 0;
        public int MaxParcelas { get; set; } = 0;
        public int MaxParcelasSemJuros { get; set; } = 0;
        [ListHasElements<FichaTecnicaDTO>(mincount: 5, ErrorMessage = "É necessário no mínimo 5 valores")]
        [ValidateObjectMembers]
        [ValidateComplexType]
        public List<FichaTecnicaDTO> Ficha { get; set; } = [];

        [ListHasElements<ProdutoImageDTO>(mincount: 1, ErrorMessage = "É necessário no mínimo 1 imagem")]
        public List<ProdutoImageDTO> Imagens { get; set; } = [];

        public event PropertyChangedEventHandler? PropertyChanged;

        public void AddInfo(FichaTecnicaDTO? newficha = null)
        {
            if (newficha == null)
            {
                newficha = new FichaTecnicaDTO(string.Empty, string.Empty, false, false);
            }

            Ficha.Add(newficha);
        }
        public void RemoveInfo(FichaTecnicaDTO item)
        {
            Ficha.Remove(item);
        }

    }
    public class FichaTecnicaDTO
    {
        public FichaTecnicaDTO(string especificação, string valor, bool isImportant, bool isInfoAdicional, Categoria_Especificação categoria = Categoria_Especificação.GENÉRICO)
        {
            Especificação = especificação;
            Valor = valor;
            IsImportant = isImportant;
            IsInfoAdicional = isInfoAdicional;
            Categoria = categoria;
        }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Especificação { get; set; } = string.Empty;
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Valor { get; set; } = string.Empty;
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public Categoria_Especificação Categoria { get; set; } = Categoria_Especificação.GENÉRICO;
        public bool IsImportant { get; set; } = false;
        public bool IsInfoAdicional { get; set; } = false;
    }

    public class ProdutoImageDTO
    {
        public ProdutoImageDTO(byte[] image, bool isloading, Guid? id = null)
        {
            Id = id ?? Guid.NewGuid();
            Image = image;
            IsLoading = isloading;
        }

        public Guid? Id { get; set; } = null;
        [Required(ErrorMessage = "Imagem inválida")]
        public byte[] Image { get; set; } = null;
        public bool IsLoading { get; set; } = false;
    }
    public class GenericProperties
    {
        public string Tipo { get; set; } = string.Empty;
        public Categoria_Produto Categoria_tipo { get; set; }
        public List<string> Propriedades { get; set; } = [];
    }
}
