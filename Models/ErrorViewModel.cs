using System;

namespace LotometroWebAspNet.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        public ErrorViewModel()
        {
        }

        public string Erro { get; set; }

        public ErrorViewModel(string erro)
        {
            this.Erro = erro;
        }
    }
}
