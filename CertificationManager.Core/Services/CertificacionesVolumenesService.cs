using AutoMapper;
using CertificationManager.Core.Abstractions.ComonResult;
using CertificationManager.Core.Abstractions.Dtos;
using CertificationManager.Core.Abstractions.Exceptions;
using CertificationManager.Core.Abstractions.Services;
using CertificationManager.Core.Resources;
using CertificationManager.Infrastructure.Abstractions.Data;
using CertificationManager.Infrastructure.Abstractions.Entities.SPs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CertificationManager.Core.Services
{
    public class CertificacionesVolumenesService : ICertificacionesVolumenesService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public CertificacionesVolumenesService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<ResultDto<ClientesDto>> Get(Guid id)
        {
            var dbClientes = await unitOfWork.CertificacionesVolumenes.GetByIdAsync(id);
            return new ResultDto<ClientesDto>(mapper.Map<ClientesDto>(dbClientes));
        }

        public async Task<ResultDto<int>> Post(ClientesDto ClientesDto)
        {
            var Clientes = mapper.Map<CertificationManager.Infrastructure.Abstractions.Entities.CertificacionesVolumenes>(ClientesDto);
            await unitOfWork.CertificacionesVolumenes.AddAsync(Clientes);
            _ = await unitOfWork.CompleteAsync();
            return new ResultDto<int>(mapper.Map<ClientesDto>(Clientes).cod);
        }

        public async Task<ResultDto<bool>> Put(ClientesDto ClientesDto)
        {
            if (ClientesDto.cod == 0)
            {
                throw new BizErrorException(ResourceKeys.IdShouldNotBeNullOrEmpty);
            }
            var dbClientes = mapper.Map<CertificationManager.Infrastructure.Abstractions.Entities.CertificacionesVolumenes>(ClientesDto);
            unitOfWork.CertificacionesVolumenes.Update(dbClientes);
            _ = await unitOfWork.CompleteAsync();
            return new ResultDto<bool>(true);

        }
        public async Task<ResultDto<bool>> Delete(Guid id)
        {
            var dbClientes = await unitOfWork.CertificacionesVolumenes.GetByIdWithTrackingAsync(id);
            if (dbClientes == null)
            {
                throw new BizErrorException(ResourceKeys.MissingEntity);
            }
            //dbClientes.IsRowDeleted = true;
            _ = await unitOfWork.CompleteAsync();
            return new ResultDto<bool>(true);
        }


        public async Task<ResultDto<List<ResponseUspWebCertificacionesVolumenesPagoDetallesObtener>>> UspWebCertificacionesVolumenesPagoDetallesObtener(int id_certificacion_volumen)
        {
            try
            {
                var response = await unitOfWork.CertificacionesVolumenes.UspWebCertificacionesVolumenesPagoDetallesObtener(id_certificacion_volumen);
                return new ResultDto<List<ResponseUspWebCertificacionesVolumenesPagoDetallesObtener>>(mapper.Map<List<ResponseUspWebCertificacionesVolumenesPagoDetallesObtener>>(response));
            }
            catch (Exception ex)
            {
                return new ResultDto<List<ResponseUspWebCertificacionesVolumenesPagoDetallesObtener>>() { StatusResult = ResultStatus.Failure, Message = "El id_certificacion_volumen es incorrecto" };
            }
        }

        public async Task<ResultDto<List<ResponseUspWebPeriodosObtener>>> UspWebPeriodosObtener(int? id_periodo)
        {
            try
            {
                var response = await unitOfWork.CertificacionesVolumenes.UspWebPeriodosObtener(id_periodo);
                return new ResultDto<List<ResponseUspWebPeriodosObtener>>(mapper.Map<List<ResponseUspWebPeriodosObtener>>(response));
            }
            catch (Exception ex)
            {
                return new ResultDto<List<ResponseUspWebPeriodosObtener>>() { StatusResult = ResultStatus.Failure, Message = "El id_certificacion_volumen es incorrecto" };
            }
        }
    }
}
