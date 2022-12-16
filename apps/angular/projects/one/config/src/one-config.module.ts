import { ModuleWithProviders, NgModule } from '@angular/core';
import { ONE_ROUTE_PROVIDERS } from './providers/route.provider';

@NgModule()
export class OneConfigModule {
  static forRoot(): ModuleWithProviders<OneConfigModule> {
    return {
      ngModule: OneConfigModule,
      providers: [ONE_ROUTE_PROVIDERS],
    };
  }
}
