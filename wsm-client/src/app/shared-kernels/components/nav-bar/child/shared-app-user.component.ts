import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-shared-nav-bar-user',
  template: `
    <!-- <div class="dropdown-header d-flex">
      <div class="flex-shrink-0">
        <i class="bx bx-md bx-user-circle"></i>
      </div>
      <div class="flex-grow-1">
        Abusaleh Md Nayeem<br />abusalehnayeem@outlook.com
      </div>
    </div> -->
    <div class="dropdown-divider"></div>
    <a class="dropdown-item">Logout</a>
  `,
})
export class AppSharedNabBarUserComponent implements OnInit {
  constructor() {}
  ngOnInit(): void {}

  // public logout() {
  //   this.customAuthService.logout();
  // }
}
