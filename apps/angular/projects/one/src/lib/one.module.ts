import { NgModule, NgModuleFactory, ModuleWithProviders } from '@angular/core';
import { CoreModule, LazyModuleFactory } from '@abp/ng.core';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { OneComponent } from './components/one.component';
import { OneRoutingModule } from './one-routing.module';

@NgModule({
  declarations: [OneComponent],
  imports: [CoreModule, ThemeSharedModule, OneRoutingModule],
  exports: [OneComponent],
})
export class OneModule {
  static forChild(): ModuleWithProviders<OneModule> {
    return {
      ngModule: OneModule,
      providers: [],
    };
  }

  static forLazy(): NgModuleFactory<OneModule> {
    return new LazyModuleFactory(OneModule.forChild());
  }
}
