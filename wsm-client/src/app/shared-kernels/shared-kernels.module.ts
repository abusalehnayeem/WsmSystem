import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { AppSharedKernelsNavbarComponent } from './components/nav-bar/all.component';
import { AppSharedNabBarUserComponent } from './components/nav-bar/child/shared-app-user.component';

@NgModule({
  declarations: [AppSharedKernelsNavbarComponent, AppSharedNabBarUserComponent],
  exports: [AppSharedKernelsNavbarComponent],
  imports: [CommonModule],
})
export class SharedKernelsModule {}
