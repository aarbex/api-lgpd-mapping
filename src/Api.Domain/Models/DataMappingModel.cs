using System;
using System.Collections.Generic;
using Api.Domain.DTOs.Dado;
using Api.Domain.Entities;
using Api.Domain.Enums;

namespace Api.Domain.Models
{
    public class DataMappingModel
    {

        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _area;
        public string Area
        {
            get { return _area; }
            set { _area = value; }
        }

        private string _processo;
        public string Processo
        {
            get { return _processo; }
            set { _processo = value; }
        }

        private string _donoProcesso;
        public string DonoProcesso
        {
            get { return _donoProcesso; }
            set { _donoProcesso = value; }
        }

        private int _volume;
        public int Volume
        {
            get { return _volume; }
            set { _volume = value; }
        }

        private FormatoEnum _formato;
        public FormatoEnum Formato
        {
            get { return _formato; }
            set { _formato = value; }
        }

        private FrequenciaEnum _frequencia;
        public FrequenciaEnum Frequencia
        {
            get { return _frequencia; }
            set { _frequencia = value; }
        }

        private NaturezaTitularEnum _naturezaTitular;
        public NaturezaTitularEnum NaturezaTitular
        {
            get { return _naturezaTitular; }
            set { _naturezaTitular = value; }
        }

        private OrigemEnum _origem;
        public OrigemEnum Origem
        {
            get { return _origem; }
            set { _origem = value; }
        }

        private TratamentoEnum _tratamento;
        public TratamentoEnum Tratamento
        {
            get { return _tratamento; }
            set { _tratamento = value; }
        }

        private BasesLegaisEnum _baseLegal;
        public BasesLegaisEnum BaseLegal
        {
            get { return _baseLegal; }
            set { _baseLegal = value; }
        }

        private bool _dadosCriancasAdolescentes;
        public bool DadosCriancasAdolescentes
        {
            get { return _dadosCriancasAdolescentes; }
            set { _dadosCriancasAdolescentes = value; }
        }

        private string _mesReferencia;
        public string MesReferencia
        {
            get { return _mesReferencia; }
            set { _mesReferencia = value; }
        }

        private string _anoReferencia;
        public string AnoReferencia
        {
            get { return _anoReferencia; }
            set { _anoReferencia = value; }
        }

        private ICollection<DadoModel> _dados;
        public virtual ICollection<DadoModel> Dados
        {
            get { return _dados; }
            set { _dados = value; }
        }

        private bool _ativo;
        public bool Ativo
        {
            get { return _ativo; }
            set { _ativo = value; }
        }
        private DateTime _dataCadastro;
        public DateTime DataCadastro
        {
            get { return _dataCadastro; }
            set { _dataCadastro = value; }
        }

        private DateTime _dataAtualizacao;
        public DateTime DataAtualizacao
        {
            get { return _dataAtualizacao; }
            set { _dataAtualizacao = value; }
        }
    }
}
