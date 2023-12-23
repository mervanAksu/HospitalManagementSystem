using Hospital.Models;
using Hospital.Repositories.Interfaces;
using Hospital.Utilities;
using Hospital.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Services
{
	public class HospitalinfoService : IHospitalInfo
	{
		private IUnitOfWork _unitOfWork;

		public HospitalinfoService(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}

		public void DeleteHospitalInfo(int id)
		{
			var model = _unitOfWork.GenericRepository<Hospitalinfo>().GetById(id);
			_unitOfWork.GenericRepository<Hospitalinfo>().Delete(model);
			_unitOfWork.Save();
		}

		public PagedResult<HospitalInfoViewModel> GetAll(int pageNumber, int pageSize)
		{
			var vm = new HospitalInfoViewModel();
			int totalCount;
			List<HospitalInfoViewModel> vmList = new List<HospitalInfoViewModel>();
			try
			{
				int ExcludeRecords = (pageSize * pageNumber) - pageSize;

				var modelList = _unitOfWork.GenericRepository<Hospitalinfo>().GetAll().Skip(ExcludeRecords).Take(pageSize).ToList();

				totalCount = _unitOfWork.GenericRepository<Hospitalinfo>().GetAll().ToList().Count;

				vmList = ConvertModelToViewModelList(modelList);
			}
			catch (Exception)
			{

				throw;
			}

			var result = new PagedResult<HospitalInfoViewModel>
			{
				Data = vmList,
				TotalItem = totalCount,
				PageNumber = pageNumber,
				PageSize = pageSize
			};
			return result;
		}

		public HospitalInfoViewModel GetHospitalById(int HospitalId)
		{
			var model = _unitOfWork.GenericRepository<Hospitalinfo>().GetById(HospitalId);
			var vm = new HospitalInfoViewModel(model);
			return vm;
		}

		public void InsertHospitalInfo(HospitalInfoViewModel hospitalInfo)
		{
			var model = new HospitalInfoViewModel().ConvertViewModel(hospitalInfo);
			_unitOfWork.GenericRepository<Hospitalinfo>().Add(model);
			_unitOfWork.Save();
		}

		public void UpdateHospitalInfo(HospitalInfoViewModel hospitalInfo)
		{
			var model = new HospitalInfoViewModel().ConvertViewModel(hospitalInfo);
			var ModelById = _unitOfWork.GenericRepository<Hospitalinfo>().GetById(model.Id);
			ModelById.Name = hospitalInfo.Name;
			ModelById.City = hospitalInfo.City;
			ModelById.PinCode = hospitalInfo.PinCode;
			ModelById.Country = hospitalInfo.Country;
			_unitOfWork.GenericRepository<Hospitalinfo>().Update(ModelById);
			_unitOfWork.Save();
		}

		private List<HospitalInfoViewModel> ConvertModelToViewModelList(List<Hospitalinfo> modelList)
		{
			return modelList.Select(x => new HospitalInfoViewModel(x)).ToList();
		}
	}
}
