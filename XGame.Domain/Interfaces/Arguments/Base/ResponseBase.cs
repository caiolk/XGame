﻿namespace XGame.Domain.Interfaces.Arguments.Base
{
    public class ResponseBase
    {
        public ResponseBase()
        {
            Message = XGame.Domain.Resources.Message.OPERACAO_REALIZADA_COM_SUCESSO;
        }
        public string Message { get; set; }
    }
}
