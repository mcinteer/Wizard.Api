﻿using System.Threading.Tasks;
using Estable.Lib.Contracts;

namespace Wizard.Api.Services.Interfaces
{
	public interface IStableService
	{
		StableDataContract Get(string email);
		string Save(StableDataContract stable);
		void SaveWithoutValidation(StableDataContract stable);
	}
}