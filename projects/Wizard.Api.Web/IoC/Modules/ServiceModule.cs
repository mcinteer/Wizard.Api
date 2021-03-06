﻿using Ninject.Modules;
using Wizard.Api.Services.Implementations;
using Wizard.Api.Services.Interfaces;

namespace Wizard.Api.IoC.Modules
{
	public class ServiceModule : NinjectModule
	{
		public override void Load()
		{
			Bind<IFinancialService>().To<FinancialService>().InSingletonScope();
			Bind<IStableService>().To<StableService>().InSingletonScope();
			Bind<IChargeTypeService>().To<ChargeTypeService>().InSingletonScope();
			Bind<IAnimalService>().To<AnimalService>().InSingletonScope();
			Bind<IEntireStableService>().To<EntireStableService>().InSingletonScope();
		}
	}
}