@charset "UTF-8";
@import url("inc/bootstrap/bootstrap.min.css");
@import url("inc/splide/splide.min.css");
@import url("https://cdn.jsdelivr.net/npm/bootstrap-icons@1.8.1/font/bootstrap-icons.css");
@import url("https://fonts.googleapis.com/css?family=Inter:400,500,700&display=swap");
body {
  font-family: "Inter", sans-serif;
  font-size: 15px;
  line-height: 1.55rem;
  letter-spacing: -0.015rem;
  color: #4F5050;
  background: rgba(45, 36, 129, 0.3098039216);
  width: 100%;
  height: 100%;
  overflow-x: hidden;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
}

::-webkit-scrollbar {
  width: 0;
}

::selection {
  background: rgba(255, 255, 255, 0.3);
}

a {
  transition: none;
  color: #ffffff;
  outline: 0 !important;
  text-decoration: none;
}
a:hover, a:active, a:focus {
  outline: 0 !important;
  color: #2E2481;
  text-decoration: none;
}

button {
  outline: 0 !important;
}
button:hover, button:active, button:focus {
  outline: 0 !important;
}

.appHeader {
  min-height: 56px;
  display: flex;
  justify-content: center;
  align-items: center;
  position: fixed;
  top: env(safe-area-inset-top);
  left: 0;
  right: 0;
  z-index: 999;
  background: #FFF;
  color: #1c1b1b;
  box-shadow: 0px 4px 4px rgba(0, 0, 0, 0.25);
}
.appHeader:before {
  content: "";
  height: env(safe-area-inset-top);
  position: fixed;
  top: 0;
  left: 0;
  right: 0;
  width: 100%;
  z-index: 9999;
  background: #2E2481;
}
.appHeader.no-border {
  border: 0;
  box-shadow: none;
}
.appHeader.transparent {
  background: transparent;
  box-shadow: none;
}
.appHeader .left,
.appHeader .right {
  height: 56px;
  display: flex;
  align-items: center;
  position: absolute;
}
.appHeader .left i.bi,
.appHeader .left i.icon,
.appHeader .left ion-icon,
.appHeader .right i.bi,
.appHeader .right i.icon,
.appHeader .right ion-icon {
  font-size: 26px;
  --ionicon-stroke-width: 36px;
}
.appHeader .left .headerButton,
.appHeader .right .headerButton {
  min-width: 36px;
  height: 56px;
  display: flex;
  align-items: center;
  justify-content: center;
  padding: 10px;
  color: #1c1b1b;
  position: relative;
}
.appHeader .left .headerButton .btn,
.appHeader .right .headerButton .btn {
  font-size: 16px;
  height: 32px;
  padding: 0px 14px;
  font-weight: 400;
}
.appHeader .left .headerButton:active,
.appHeader .right .headerButton:active {
  opacity: 0.6;
}
.appHeader .left {
  left: 8px;
  top: 0;
}
.appHeader .right {
  right: 8px;
  top: 0;
}
.appHeader .pageTitle {
  font-size: 17px;
  font-weight: 500;
  padding: 0 10px;
}
.appHeader .pageTitle .logo {
  max-height: 18px;
}
.appHeader.text-light {
  color: #fff;
}
.appHeader.text-light .headerButton,
.appHeader.text-light .pageTitle {
  color: #fff;
}
.appHeader.bg-primary, .appHeader.bg-secondary, .appHeader.bg-success, .appHeader.bg-warning, .appHeader.bg-danger, .appHeader.bg-info, .appHeader.bg-light, .appHeader.bg-dark {
  border: 0;
}

.extraHeader {
  position: fixed;
  left: 0;
  top: 56px;
  height: 56px;
  right: 0;
  width: 100%;
  padding: 5px 16px;
  margin-top: env(safe-area-inset-top);
  display: flex;
  align-items: center;
  background: #fff;
  z-index: 1000;
  box-shadow: 0px 4px 4px rgba(0, 0, 0, 0.25);
}

.header-large-title {
  padding: 0 16px;
}
.header-large-title .title {
  margin: 4px 0 0 0;
  font-size: 34px;
  letter-spacing: -0.02em;
  line-height: 1.3em;
}
.header-large-title .subtitle {
  font-size: 17px;
  font-weight: 400;
  margin: 6px 0 0 0;
  color: #1c1b1b;
  line-height: 1.6em;
}

.appHeader.scrolled {
  background: transparent;
  border-bottom: 1px solid transparent;
  box-shadow: none;
  height: 0;
  transition: 0.1s all;
}
.appHeader.scrolled .pageTitle {
  opacity: 0;
}
.appHeader.scrolled.is-active {
  background: #FFF;
  min-height: 56px;
  border-bottom-color: #E1E1E1;
  box-shadow: 0px 4px 4px rgba(0, 0, 0, 0.25);
}
.appHeader.scrolled.is-active .pageTitle {
  opacity: 1;
}

.appHeader.scrolled.bg-primary {
  background: transparent !important;
  border-bottom: 0 !important;
}
.appHeader.scrolled.bg-primary .headerButton {
  color: #2E2481;
}
.appHeader.scrolled.bg-primary.is-active {
  background: #2E2481 !important;
}
.appHeader.scrolled.bg-primary.is-active .headerButton {
  color: #FFF !important;
}

.appHeader.scrolled.bg-secondary {
  background: transparent !important;
  border-bottom: 0 !important;
}
.appHeader.scrolled.bg-secondary .headerButton {
  color: #53AAC6;
}
.appHeader.scrolled.bg-secondary.is-active {
  background: #53AAC6 !important;
}
.appHeader.scrolled.bg-secondary.is-active .headerButton {
  color: #FFF !important;
}

.appHeader.scrolled.bg-success {
  background: transparent !important;
  border-bottom: 0 !important;
}
.appHeader.scrolled.bg-success .headerButton {
  color: #C7FB93;
}
.appHeader.scrolled.bg-success.is-active {
  background: #C7FB93 !important;
}
.appHeader.scrolled.bg-success.is-active .headerButton {
  color: #FFF !important;
}

.appHeader.scrolled.bg-danger {
  background: transparent !important;
  border-bottom: 0 !important;
}
.appHeader.scrolled.bg-danger .headerButton {
  color: #FB9393;
}
.appHeader.scrolled.bg-danger.is-active {
  background: #FB9393 !important;
}
.appHeader.scrolled.bg-danger.is-active .headerButton {
  color: #FFF !important;
}

.appHeader.scrolled.bg-warning {
  background: transparent !important;
  border-bottom: 0 !important;
}
.appHeader.scrolled.bg-warning .headerButton {
  color: #FBC593;
}
.appHeader.scrolled.bg-warning.is-active {
  background: #FBC593 !important;
}
.appHeader.scrolled.bg-warning.is-active .headerButton {
  color: #FFF !important;
}

.appHeader.scrolled.bg-info {
  background: transparent !important;
  border-bottom: 0 !important;
}
.appHeader.scrolled.bg-info .headerButton {
  color: #ffffff;
}
.appHeader.scrolled.bg-info.is-active {
  background: #ffffff !important;
}
.appHeader.scrolled.bg-info.is-active .headerButton {
  color: #FFF !important;
}

.appHeader.scrolled.bg-dark {
  background: transparent !important;
  border-bottom: 0 !important;
}
.appHeader.scrolled.bg-dark .headerButton {
  color: #000;
}
.appHeader.scrolled.bg-dark.is-active {
  background: #000 !important;
}
.appHeader.scrolled.bg-dark.is-active .headerButton {
  color: #FFF !important;
}

.appBottomMenu {
  min-height: 56px;
  position: fixed;
  z-index: 999;
  bottom: 0;
  left: 0;
  right: 0;
  background: #FFFFFF;
  display: flex;
  align-items: center;
  justify-content: center;
  border-top: 1px solid #E1E1E1;
  padding-left: 4px;
  padding-right: 4px;
  padding-bottom: env(safe-area-inset-bottom);
}
.appBottomMenu.no-border {
  border: 0 !important;
  box-shadow: 0 !important;
}
.appBottomMenu.rounded {
  border-radius: 24px 24px 0 0 !important;
}
.appBottomMenu.rounded .item:before {
  display: none;
}
.appBottomMenu .item {
  font-size: 9px;
  letter-spacing: 0;
  text-align: center;
  width: 100%;
  height: 56px;
  line-height: 1.2em;
  display: flex;
  align-items: center;
  justify-content: center;
  position: relative;
}
.appBottomMenu .item:before {
  content: "";
  display: block;
  height: 2px;
  border-radius: 0 0 10px 10px;
  background: transparent;
  position: absolute;
  left: 4px;
  right: 4px;
  top: 0;
}
.appBottomMenu .item .col {
  width: 100%;
  padding: 0 4px;
  text-align: center;
}
.appBottomMenu .item i.bi,
.appBottomMenu .item i.icon,
.appBottomMenu .item ion-icon {
  display: inline-flex;
  margin: 1px auto 3px auto;
  font-size: 26px;
  line-height: 1em;
  color: #1c1b1b;
  transition: none;
  display: block;
  margin-top: 1px;
  margin-bottom: 3px;
}
.appBottomMenu .item .action-button {
  display: inline-flex;
  width: 50px;
  height: 50px;
  margin-left: -5px;
  margin-right: -5px;
  align-items: center;
  justify-content: center;
  border-radius: 200px;
  background: #2E2481;
}
.appBottomMenu .item .action-button.large {
  width: 60px;
  height: 60px;
  margin-top: -20px;
  margin-left: -10px;
  margin-right: -10px;
}
.appBottomMenu .item .action-button i.bi,
.appBottomMenu .item .action-button i.icon,
.appBottomMenu .item .action-button ion-icon {
  color: #FFF !important;
  margin: 0 !important;
  line-height: 0 !important;
}
.appBottomMenu .item strong {
  margin-top: 4px;
  display: block;
  color: #1c1b1b;
  font-weight: 400;
  transition: none;
}
.appBottomMenu .item:active {
  opacity: 0.8;
}
.appBottomMenu .item.active:before {
  background: transparent;
}
.appBottomMenu .item.active i.bi,
.appBottomMenu .item.active i.icon,
.appBottomMenu .item.active ion-icon,
.appBottomMenu .item.active strong {
  color: #2E2481 !important;
  font-weight: 500;
}
.appBottomMenu .item:hover i.bi,
.appBottomMenu .item:hover i.icon,
.appBottomMenu .item:hover ion-icon,
.appBottomMenu .item:hover strong {
  color: #1c1b1b;
}
.appBottomMenu.text-light {
  color: #FFF;
}
.appBottomMenu.text-light .item {
  color: #FFF;
  opacity: 0.7;
}
.appBottomMenu.text-light .item i.bi,
.appBottomMenu.text-light .item i.icon,
.appBottomMenu.text-light .item ion-icon,
.appBottomMenu.text-light .item strong {
  color: #FFF;
}
.appBottomMenu.text-light .item.active {
  opacity: 1;
}
.appBottomMenu.text-light .item.active i.bi,
.appBottomMenu.text-light .item.active i.icon,
.appBottomMenu.text-light .item.active ion-icon,
.appBottomMenu.text-light .item.active strong {
  color: #FFF !important;
}
.appBottomMenu.bg-primary, .appBottomMenu.bg-secondary, .appBottomMenu.bg-success, .appBottomMenu.bg-warning, .appBottomMenu.bg-danger, .appBottomMenu.bg-info, .appBottomMenu.bg-light, .appBottomMenu.bg-dark {
  border: 0;
}
.appBottomMenu.bg-primary .item:before, .appBottomMenu.bg-secondary .item:before, .appBottomMenu.bg-success .item:before, .appBottomMenu.bg-warning .item:before, .appBottomMenu.bg-danger .item:before, .appBottomMenu.bg-info .item:before, .appBottomMenu.bg-light .item:before, .appBottomMenu.bg-dark .item:before {
  display: none;
}

.infinite-menu {
  display: block;
  overflow-x: auto;
  white-space: nowrap;
  margin: 0;
}
.infinite-menu::-webkit-scrollbar {
  width: 0;
  height: 0;
}
.infinite-menu .item {
  display: inline-flex;
  flex: unset;
  margin: 0 5px 0 0;
  width: 20%;
}

#appCapsule {
  padding: 56px 0;
  margin-bottom: env(safe-area-inset-bottom);
  margin-top: env(safe-area-inset-top);
}
#appCapsule.extra-header-active {
  padding-top: 112px;
}
#appCapsule.full-height {
  min-height: 100vh;
}

.section {
  padding: 0 16px;
}
.section.full {
  padding: 0;
}

.wide-block {
  background: #fff;
  border-top: 1px solid #E1E1E1;
  border-bottom: 1px solid #E1E1E1;
  padding-left: 16px;
  padding-right: 16px;
}
.wide-block.transparent {
  background: transparent !important;
}

.section-title {
  font-size: 15px;
  padding: 6px 0;
  display: flex;
  align-items: center;
  justify-content: space-between;
  color: #1c1b1b;
  font-weight: 500;
}
.section-title.large {
  font-size: 24px;
  line-height: 1.2em;
  font-weight: 700;
}
.section-title.medium {
  font-size: 17px;
  font-weight: 700;
}

.content-header,
.content-footer {
  font-size: 11px;
  color: #939393;
  padding-left: 0;
  padding-right: 0;
  line-height: 1.4em;
}

.section.full .section-title {
  padding-left: 16px;
  padding-right: 16px;
}
.section.full .content-header,
.section.full .content-footer {
  padding-left: 16px;
  padding-right: 16px;
}
.section.full .wide-block .content-header,
.section.full .wide-block .content-footer {
  padding-left: 0;
  padding-right: 0;
}

.section.inset .wide-block {
  border: 1px solid #E1E1E1;
  border-radius: 24px;
}

.profileBox {
  width: 300px;
  padding-left: 16px;
  padding-right: 16px;
  display: flex;
  align-items: center;
  position: relative;
  background: #2E2481;
  box-shadow: 0px 4px 4px rgba(0, 0, 0, 0.25);
  position: fixed;
  z-index: 100;
  left: 0;
  top: 0;
  margin-top: env(safe-area-inset-top);
}
.profileBox:before {
  background: #2E2481;
  content: "";
  height: env(safe-area-inset-top);
  display: block;
  position: fixed;
  top: 0;
  left: 0;
  width: 300px;
}
.profileBox .image-wrapper {
  margin-right: 16px;
  padding: 16px 0;
}
.profileBox .image-wrapper .imaged {
  width: 42px;
  height: 42px;
  border: 2px solid #2E2481;
  box-shadow: 0px 4px 4px rgba(0, 0, 0, 0.25);
}
.profileBox .in {
  line-height: 1.4em;
  padding: 16px 25px 16px 0;
}
.profileBox .in strong {
  display: block;
  font-weight: 500;
  color: #FFF;
}
.profileBox .in .text-muted {
  font-size: 14px;
  color: rgba(255, 255, 255, 0.5) !important;
}

.sidebar-buttons {
  width: 300px;
  background: #FFF;
  border-top: 1px solid #E1E1E1;
  display: flex;
  align-items: center;
  justify-content: flex-start;
  position: fixed;
  left: 0;
  bottom: 0;
  right: 0;
  padding-bottom: env(safe-area-inset-bottom);
}
.sidebar-buttons .button {
  width: 100%;
  height: 56px;
  display: flex;
  align-items: center;
  justify-content: center;
  font-size: 26px;
  color: #1c1b1b;
}
.sidebar-buttons .button:hover, .sidebar-buttons .button:active {
  background: rgba(225, 225, 225, 0.2);
}
.sidebar-buttons:last-child {
  border-right-color: transparent;
}

.close-sidebar-button {
  font-size: 22px;
  position: absolute;
  width: 36px;
  display: flex;
  align-items: center;
  border-radius: 100%;
  justify-content: center;
  height: 36px;
  right: 10px;
  top: 50%;
  color: rgba(255, 255, 255, 0.5) !important;
  margin-top: -18px;
}
.close-sidebar-button:active {
  background: rgba(255, 255, 255, 0.1);
}

.action-group {
  display: flex;
  align-items: flex-start;
  justify-content: space-between;
  padding: 0px 16px 10px 16px;
  background: #2E2481;
}
.action-group .action-button {
  padding: 10px 2px;
  display: inline-flex;
  align-items: center;
  justify-content: center;
  text-align: center;
  font-size: 11px;
  line-height: 1em;
  color: rgba(255, 255, 255, 0.7);
}
.action-group .action-button .iconbox {
  background: rgba(0, 0, 0, 0.3);
  width: 38px;
  height: 38px;
  margin: 0 auto 8px auto;
  border-radius: 100%;
  font-size: 18px;
  color: #FFF;
  display: flex;
  align-items: center;
  justify-content: center;
}
.action-group .action-button:last-child {
  border-right: 0;
}

#sidebarPanel {
  padding: 0;
  padding-top: env(safe-area-inset-top);
  padding-bottom: env(safe-area-inset-bottom);
}
#sidebarPanel .offcanvas-body {
  padding: 0 0 70px 0;
  margin-top: 74px;
}
#sidebarPanel .modal-content {
  width: 300px;
  padding-top: env(safe-area-inset-top);
}

.panelbox-left .listview > li,
.panelbox-right .listview > li {
  padding: 10px 16px;
}
.panelbox-left .link-listview > li,
.panelbox-right .link-listview > li {
  padding: 0;
}
.panelbox-left .link-listview > li a,
.panelbox-right .link-listview > li a {
  padding: 10px 36px 10px 16px;
}
.panelbox-left .image-listview > li,
.panelbox-right .image-listview > li {
  padding: 0;
}
.panelbox-left .image-listview > li .item,
.panelbox-right .image-listview > li .item {
  padding: 10px 16px;
}
.panelbox-left .image-listview > li a.item,
.panelbox-right .image-listview > li a.item {
  padding-right: 36px;
}

.sidebar-close {
  position: absolute;
  right: 10px;
}

.appFooter {
  border-top: 1px solid #E1E1E1;
  padding: 24px 16px;
  font-size: 12px;
  text-align: center;
  line-height: 1.2em;
  background: #2E2481;
}
.appFooter .footer-title {
  font-weight: 500;
  color: #1c1b1b;
  margin-bottom: 8px;
}
.appFooter .btn {
  margin: 0 5px;
}

.fixed-footer {
  position: fixed;
  bottom: 0;
  left: 0;
  min-height: 84px;
  right: 0;
  background: #ff5100;
  display: flex;
  align-items: center;
  justify-content: center;
  padding-left: 8px;
  padding-right: 8px;
  padding-bottom: env(safe-area-inset-bottom);
}
.fixed-footer > div {
  width: 100%;
}
.fixed-footer.transparent {
  background: transparent !important;
}

.footer-logo {
  height: 16px;
}

.footer-link {
  padding: 0;
  border-top: 1px solid rgba(225, 225, 225, 0.5);
  border-bottom: 1px solid rgba(225, 225, 225, 0.5);
  margin-left: -16px;
  margin-right: -16px;
  display: flex;
  align-items: center;
  justify-content: space-between;
}
.footer-link a {
  flex: 1;
  padding: 12px 2px;
  width: 100%;
  color: #4F5050;
  display: block;
}
.footer-link a span {
  display: block;
}
.footer-link a i.bi,
.footer-link a i.icon,
.footer-link a ion-icon {
  font-size: 24px;
  margin-bottom: 4px;
}

.exampleBox {
  width: 100%;
  height: 40px;
  display: flex;
  align-items: center;
  justify-content: center;
  border: 1px solid #E1E1E1;
  background: rgba(225, 225, 225, 0.3);
  font-size: 10px;
}

.demoPage .appHeader {
  position: relative;
  z-index: 0;
}
.demoPage .appHeader:before {
  height: 0 !important;
  display: none;
}
.demoPage .appBottomMenu {
  position: relative;
  z-index: 0;
  padding-bottom: 0;
}

.row {
  margin-left: -8px;
  margin-right: -8px;
}

.col-1,
.col-2,
.col-3,
.col-4,
.col-5,
.col-6,
.col-7,
.col-8,
.col-9,
.col-10,
.col-11,
.col-12,
.col-sm-1,
.col-sm-2,
.col-sm-3,
.col-sm-4,
.col-sm-5,
.col-sm-6,
.col-sm-7,
.col-sm-8,
.col-sm-9,
.col-sm-10,
.col-sm-11,
.col-sm-12,
.col-md-1,
.col-md-2,
.col-md-3,
.col-md-4,
.col-md-5,
.col-md-6,
.col-md-7,
.col-md-8,
.col-md-9,
.col-md-10,
.col-md-11,
.col-md-12,
.col-lg-1,
.col-lg-2,
.col-lg-3,
.col-lg-4,
.col-lg-5,
.col-lg-6,
.col-lg-7,
.col-lg-8,
.col-lg-9,
.col-lg-10,
.col-lg-11,
.col-lg-12,
.col-xl-1,
.col-xl-2,
.col-xl-3,
.col-xl-4,
.col-xl-5,
.col-xl-6,
.col-xl-7,
.col-xl-8,
.col-xl-9,
.col-xl-10,
.col-xl-11,
.col-xl-12 {
  padding-left: 8px;
  padding-right: 8px;
}

.m-0 {
  margin: 0 !important;
}

.m-05 {
  margin: 5px !important;
}

.m-1 {
  margin: 8px !important;
}

.m-2 {
  margin: 16px !important;
}

.m-3 {
  margin: 24px !important;
}

.m-4 {
  margin: 32px !important;
}

.m-5 {
  margin: 40px !important;
}

.mt-0 {
  margin-top: 0 !important;
}

.mt-05 {
  margin-top: 5px !important;
}

.mt-1 {
  margin-top: 8px !important;
}

.mt-2 {
  margin-top: 16px !important;
}

.mt-3 {
  margin-top: 24px !important;
}

.mt-4 {
  margin-top: 32px !important;
}

.mt-5 {
  margin-top: 40px !important;
}

.mb-0 {
  margin-bottom: 0px !important;
}

.mb-05 {
  margin-bottom: 5px !important;
}

.mb-1 {
  margin-bottom: 8px !important;
}

.mb-2 {
  margin-bottom: 16px !important;
}

.mb-3 {
  margin-bottom: 24px !important;
}

.mb-4 {
  margin-bottom: 32px !important;
}

.mb-5 {
  margin-bottom: 40px !important;
}

.ms-0 {
  margin-left: 0 !important;
}

.ms-05 {
  margin-left: 5px !important;
}

.ms-1 {
  margin-left: 8px !important;
}

.ms-2 {
  margin-left: 16px !important;
}

.ms-3 {
  margin-left: 24px !important;
}

.ms-4 {
  margin-left: 32px !important;
}

.ms-5 {
  margin-left: 40px !important;
}

.me-0 {
  margin-right: 0px !important;
}

.me-05 {
  margin-right: 5px !important;
}

.me-1 {
  margin-right: 8px !important;
}

.me-2 {
  margin-right: 16px !important;
}

.me-3 {
  margin-right: 24px !important;
}

.me-4 {
  margin-right: 32px !important;
}

.me-5 {
  margin-right: 40px !important;
}

.p-0 {
  padding: 0 !important;
}

.p-05 {
  padding: 5px !important;
}

.p-1 {
  padding: 8px !important;
}

.p-2 {
  padding: 16px !important;
}

.p-3 {
  padding: 24px !important;
}

.p-4 {
  padding: 32px !important;
}

.p-5 {
  padding: 40px !important;
}

.pt-0 {
  padding-top: 0px !important;
}

.pt-05 {
  padding-top: 5px !important;
}

.pt-1 {
  padding-top: 8px !important;
}

.pt-2 {
  padding-top: 16px !important;
}

.pt-3 {
  padding-top: 24px !important;
}

.pt-4 {
  padding-top: 32px !important;
}

.pt-5 {
  padding-top: 40px !important;
}

.pb-0 {
  padding-bottom: 0px !important;
}

.pb-05 {
  padding-bottom: 5px !important;
}

.pb-1 {
  padding-bottom: 8px !important;
}

.pb-2 {
  padding-bottom: 16px !important;
}

.pb-3 {
  padding-bottom: 24px !important;
}

.pb-4 {
  padding-bottom: 32px !important;
}

.pb-5 {
  padding-bottom: 40px !important;
}

.ps-0 {
  padding-left: 0px !important;
}

.ps-05 {
  padding-left: 5px !important;
}

.ps-1 {
  padding-left: 8px !important;
}

.ps-2 {
  padding-left: 16px !important;
}

.ps-3 {
  padding-left: 24px !important;
}

.ps-4 {
  padding-left: 32px !important;
}

.ps-5 {
  padding-left: 40px !important;
}

.pe-0 {
  padding-right: 0px !important;
}

.pe-05 {
  padding-right: 5px !important;
}

.pe-1 {
  padding-right: 8px !important;
}

.pe-2 {
  padding-right: 16px !important;
}

.pe-3 {
  padding-right: 24px !important;
}

.pe-4 {
  padding-right: 32px !important;
}

.pe-5 {
  padding-right: 40px !important;
}

h1,
h2,
h3,
h4,
h5,
h6 {
  color: #1c1b1b;
  margin: 0 0 10px 0;
  letter-spacing: -0.02em;
  line-height: 1.3em;
}
h1 small,
h2 small,
h3 small,
h4 small,
h5 small,
h6 small {
  color: rgba(28, 27, 27, 0.6);
}
h1 .badge,
h2 .badge,
h3 .badge,
h4 .badge,
h5 .badge,
h6 .badge {
  line-height: 1em;
}

.text-muted {
  font-size: 13px;
  color: #4F5050 !important;
}

h1 {
  font-size: 34px;
  font-weight: 700;
}

h2 {
  font-size: 24px;
  font-weight: 700;
}

h3 {
  font-size: 17px;
  font-weight: 700;
}

h4 {
  font-size: 15px;
  font-weight: 500;
}

h5 {
  font-size: 13px;
  font-weight: 500;
}

h6 {
  font-size: 11px;
  font-weight: 500;
}

.lead {
  font-weight: 400;
  font-size: 17px;
  color: #4F5050 !important;
}

mark {
  border-radius: 24px;
}

.text-large {
  font-size: 34px;
}

strong,
b {
  font-weight: 500;
}

.page-title {
  display: flex;
  align-items: flex-end;
  justify-content: space-between;
}
.page-title.inset {
  padding-left: 16px;
  padding-right: 16px;
}
.page-title .in {
  padding-right: 16px;
}
.page-title .link {
  font-size: 13px;
  font-weight: 500;
  display: flex;
  align-items: center;
  justify-content: center;
  margin-bottom: 3px;
}
.page-title .link:hover, .page-title .link:active {
  opacity: 0.8;
}
.page-title strong {
  font-weight: 500;
  color: #939393;
  font-size: 13px;
  text-transform: uppercase;
  line-height: 1.2em;
}
.page-title .title {
  margin: 0;
  font-size: 24px;
  line-height: 1.2em;
}

.section.full .page-title {
  padding-left: 16px;
  padding-right: 16px;
}

code {
  color: #2E2481;
}

figure.codebox {
  background: #E1E1E1;
  border-radius: 24px;
  padding: 5px 12px;
}
figure.codebox code {
  color: #1c1b1b;
  line-height: 1.2em;
}

.placeholder-xs {
  min-height: 0.5em;
}

.placeholder-sm {
  min-height: 0.7em;
}

.placeholder-lg {
  min-height: 1.6em;
}

ion-icon {
  --ionicon-stroke-width: 32px;
}

i.icon,
i.bi {
  line-height: 1em !important;
}

i.bi {
  transform: scale(0.91);
}

.demoIcons {
  font-size: 32px;
  color: #1c1b1b;
}

.iconedbox {
  display: inline-flex;
  align-items: center;
  justify-content: center;
  font-size: 24px;
  line-height: 1em;
  width: 32px;
  height: 32px;
  border-radius: 24px;
}
.iconedbox i.bi {
  transform: scale(0.8);
}
.iconedbox.iconedbox-sm {
  width: 26px;
  height: 26px;
  font-size: 18px;
  line-height: 1em;
}
.iconedbox.iconedbox-lg {
  width: 64px;
  height: 64px;
  font-size: 42px;
  line-height: 1em;
}
.iconedbox.iconedbox-xl {
  width: 96px;
  height: 96px;
  font-size: 64px;
  line-height: 1em;
}
.iconedbox.iconedbox-xxl {
  width: 144px;
  height: 144px;
  font-size: 90px;
  line-height: 1em;
}

.imaged {
  height: auto;
  border-radius: 24px;
}
.imaged.w16 {
  width: 16px !important;
}
.imaged.w24 {
  width: 24px !important;
}
.imaged.w32 {
  width: 32px !important;
}
.imaged.w36 {
  width: 36px !important;
}
.imaged.w48 {
  width: 48px !important;
}
.imaged.w64 {
  width: 64px !important;
}
.imaged.w76 {
  width: 76px !important;
}
.imaged.w86 {
  width: 86px !important;
}
.imaged.w100 {
  width: 100px !important;
}
.imaged.w120 {
  width: 120px !important;
}
.imaged.w140 {
  width: 140px !important;
}
.imaged.w160 {
  width: 160px !important;
}
.imaged.w180 {
  width: 180px !important;
}
.imaged.w200 {
  width: 200px !important;
}
.imaged.img-fluid {
  width: 100%;
}
.imaged.rounded {
  border-radius: 100% !important;
}
.imaged.radius {
  border-radius: 24px !important;
}
.imaged.square {
  border-radius: 0 !important;
}
.imaged.filter-grayscale {
  filter: grayscale(100%);
}
.imaged.filter-sepia {
  filter: sepia(80%);
}
.imaged.filter-blur {
  filter: blur(1px);
}
.imaged.shadowed {
  box-shadow: 0px 4px 4px rgba(0, 0, 0, 0.25);
}
.imaged.mirrored {
  transform: scaleX(-1);
}

#loader {
  position: fixed;
  left: 0;
  top: 0;
  right: 0;
  bottom: 0;
  z-index: 99999;
  background: #FFF;
  display: flex;
  align-items: center;
  justify-content: center;
}
#loader .loading-icon {
  width: 42px;
  height: auto;
  animation: loadingAnimation 1s infinite;
}

@keyframes loadingAnimation {
  0% {
    transform: rotate(0deg);
  }
  100% {
    transform: rotate(360deg);
  }
}
.badge {
  font-size: 12px;
  line-height: 1em;
  border-radius: 100px;
  letter-spacing: 0;
  height: 22px;
  min-width: 22px;
  padding: 0 6px;
  display: inline-flex;
  align-items: center;
  justify-content: center;
  font-weight: 400;
}

.badge-primary,
a.badge-primary {
  background: #2E2481 !important;
}

.badge-secondary,
a.badge-secondary {
  background: #53AAC6 !important;
}

.badge-success,
a.badge-success {
  background: #C7FB93 !important;
}

.badge-danger,
a.badge-danger {
  background: #FB9393 !important;
}

.badge-warning,
a.badge-warning {
  background: #FBC593 !important;
  color: #FFF;
}

.badge-info,
a.badge-info {
  background: #ffffff !important;
}

.badge-light,
a.badge-light {
  background: rgba(255, 255, 255, 0.6) !important;
  color: #1c1b1b;
}

.badge-dark,
a.badge-dark {
  background: #222 !important;
}

.badge-empty {
  display: block !important;
  min-width: 8px !important;
  width: 8px !important;
  height: 8px !important;
  padding: 0 !important;
  font-size: 0px;
}

.appHeader .badge {
  min-width: 16px;
  height: 16px;
  line-height: 9px !important;
  font-size: 10px;
  padding: 0 4px !important;
  position: absolute;
  right: 2px;
  top: 10px;
}
.appHeader .badge-empty {
  top: 14px;
}

.appBottomMenu .badge {
  min-width: 16px;
  height: 16px;
  line-height: 9px !important;
  font-size: 10px;
  padding: 0 4px !important;
  position: absolute;
  right: 50%;
  transform: translateX(120%);
  top: 10px;
}
.appBottomMenu .badge-empty {
  transform: translateX(200%);
  top: 10px;
}

.listview-title {
  color: #4F5050;
  padding: 7px 16px;
  font-size: 13px;
  font-weight: 500;
  display: flex;
  align-items: center;
  justify-content: space-between;
}
.listview-title .link {
  color: #939393;
  font-weight: 500;
  font-size: 11px;
  display: flex;
  align-items: center;
}
.listview-title .link i.bi,
.listview-title .link i.icon,
.listview-title .link ion-icon {
  font-size: 15px;
  margin-right: 4px;
}
.listview-title.sticky-title {
  background: rgba(45, 36, 129, 0.3098039216);
  position: -webkit-sticky;
  position: -moz-sticky;
  position: -o-sticky;
  position: -ms-sticky;
  position: sticky;
  padding-top: 8px;
  padding-bottom: 8px;
  z-index: 500;
  top: 56px;
  font-weight: 500;
  color: #1c1b1b;
  box-shadow: 0px 1px 0 #E1E1E1, 0px -1px 0 #E1E1E1;
}
.listview-title.sticky-title strong {
  font-size: 15px;
}
.listview-title .text-small {
  font-size: 11px;
  color: #939393;
  line-height: 1.3em;
}

.listview {
  display: block;
  padding: 0;
  margin: 0;
  color: #1c1b1b;
  background: #fff;
  border-top: 1px solid #E1E1E1;
  border-bottom: 1px solid #E1E1E1;
  line-height: 1.3em;
}
.listview .text-muted {
  font-size: 13px;
  color: #939393 !important;
}
.listview > li {
  padding: 8px 16px;
  display: block;
  align-items: center;
  justify-content: space-between;
  position: relative;
  min-height: 50px;
}
.listview > li .item {
  position: relative;
}
.listview > li:after {
  content: "";
  display: block;
  position: absolute;
  left: 0;
  right: 0;
  bottom: 0;
  height: 1px;
  background: #E1E1E1;
}
.listview > li:last-child:after {
  display: none;
}
.listview > li footer,
.listview > li header {
  font-size: 12px;
  margin: 0;
  line-height: 1.2em;
}
.listview > li footer {
  color: #4F5050;
  margin-top: 3px;
}
.listview > li header {
  margin-bottom: 3px;
}
.listview > li.divider-title {
  background: rgba(225, 225, 225, 0.5);
  margin-top: -1px;
  border-top: 1px solid #E1E1E1;
  border-bottom: 1px solid #E1E1E1;
  padding: 12px 16px;
  font-size: 13px;
  min-height: auto;
  color: #4F5050;
}
.listview > li.divider-title:after {
  display: none;
}
.listview.flush {
  border-top: 0;
  border-bottom: 0;
}
.listview.transparent {
  background: transparent;
}

.simple-listview > li {
  display: flex;
}

.link-listview > li {
  padding: 0;
  min-height: auto;
}
.link-listview > li a {
  padding: 8px 36px 8px 16px;
  min-height: 50px;
  display: flex;
  width: 100%;
  align-items: center;
  justify-content: space-between;
  color: #1c1b1b !important;
}
.link-listview > li a:after {
  background-image: url("data:image/svg+xml,%0A%3Csvg width='10px' height='16px' viewBox='0 0 10 16' version='1.1' xmlns='http://www.w3.org/2000/svg' xmlns:xlink='http://www.w3.org/1999/xlink'%3E%3Cg id='Page-1' stroke='none' stroke-width='1' fill='none' fill-rule='evenodd' stroke-linecap='round' stroke-linejoin='round'%3E%3Cg id='Listview' transform='translate(-112.000000, -120.000000)' stroke='%23939393' stroke-width='2.178'%3E%3Cpolyline id='Path' points='114 122 120 128 114 134'%3E%3C/polyline%3E%3C/g%3E%3C/g%3E%3C/svg%3E");
  background-repeat: no-repeat;
  background-position: center center;
  width: 16px;
  height: 16px;
  content: "";
  position: absolute;
  right: 12px;
  opacity: 0.5;
  top: 50%;
  margin-top: -8px;
}
.link-listview > li a:active {
  background: rgba(225, 225, 225, 0.3);
}

.image-listview > li {
  padding: 0;
  min-height: auto;
}
.image-listview > li:after {
  left: 68px;
}
.image-listview > li .item {
  padding: 10px 16px;
  width: 100%;
  min-height: 50px;
  display: flex;
  align-items: center;
}
.image-listview > li .item .image {
  min-width: 36px;
  max-width: 36px;
  width: 36px;
  height: 36px;
  border-radius: 400px;
  margin-right: 16px;
}
.image-listview > li .item .icon-box {
  min-width: 36px;
  max-width: 36px;
  width: 36px;
  height: 36px;
  display: flex;
  align-items: center;
  justify-content: center;
  line-height: 1em;
  font-size: 20px;
  border-radius: 400px;
  margin-right: 16px;
}
.image-listview > li .item .icon-box.bg-primary, .image-listview > li .item .icon-box.bg-secondary, .image-listview > li .item .icon-box.bg-success, .image-listview > li .item .icon-box.bg-danger, .image-listview > li .item .icon-box.bg-warning, .image-listview > li .item .icon-box.bg-info, .image-listview > li .item .icon-box.bg-dark, .image-listview > li .item .icon-box.bg-light {
  box-shadow: inset 0 0 0 1px rgba(255, 255, 255, 0.12);
}
.image-listview > li .item .in {
  display: flex;
  align-items: center;
  justify-content: space-between;
  width: 100%;
}
.image-listview > li a.item {
  color: #1c1b1b !important;
  padding-right: 36px;
}
.image-listview > li a.item:active {
  background: rgba(225, 225, 225, 0.3);
}
.image-listview > li a.item:after {
  background-image: url("data:image/svg+xml,%0A%3Csvg width='10px' height='16px' viewBox='0 0 10 16' version='1.1' xmlns='http://www.w3.org/2000/svg' xmlns:xlink='http://www.w3.org/1999/xlink'%3E%3Cg id='Page-1' stroke='none' stroke-width='1' fill='none' fill-rule='evenodd' stroke-linecap='round' stroke-linejoin='round'%3E%3Cg id='Listview' transform='translate(-112.000000, -120.000000)' stroke='%23939393' stroke-width='2.178'%3E%3Cpolyline id='Path' points='114 122 120 128 114 134'%3E%3C/polyline%3E%3C/g%3E%3C/g%3E%3C/svg%3E");
  background-repeat: no-repeat;
  background-position: center center;
  width: 16px;
  height: 16px;
  content: "";
  position: absolute;
  right: 12px;
  opacity: 0.5;
  top: 50%;
  margin-top: -8px;
}
.image-listview.text > li:after {
  left: 16px;
}
.image-listview.media > li {
  border-bottom: 1px solid #E1E1E1;
}
.image-listview.media > li:last-child {
  border-bottom: 0;
}
.image-listview.media > li .imageWrapper {
  margin-right: 16px;
}
.image-listview.media > li:after {
  display: none;
}

.listview.no-line > li:after,
.listview.no-line .item :after {
  display: none;
}

.listview.no-space > li .item {
  padding: 0;
}

.multi-level > a:after {
  transform: rotate(90deg);
}
.multi-level ul {
  border: 0;
  padding: 0;
  height: 0;
  overflow: hidden;
  transition: height 0.15s ease-in-out !important;
}
.multi-level ul > li {
  border: 0 !important;
}
.multi-level ul > li:after {
  height: 0;
}
.multi-level ul > li a,
.multi-level ul > li .item {
  padding-left: 68px !important;
}
.multi-level.active > a:after {
  transform: rotate(-90deg);
}
.multi-level.active ul {
  overflow: auto;
}

.link-listview .link-listview a,
.link-listview .link-listview .item,
.link-listview .image-listview a,
.link-listview .image-listview .item {
  padding-left: 16px !important;
}
.link-listview .image-listview.media > li {
  border: 0;
}
.link-listview .simple-listview {
  padding-left: 0 !important;
}

.image-listview .simple-listview {
  padding-left: 52px !important;
}

.image-listview.text .simple-listview {
  padding-left: 0 !important;
}
.image-listview.text .link-listview a,
.image-listview.text .link-listview .item,
.image-listview.text .image-listview a,
.image-listview.text .image-listview .item {
  padding-left: 16px !important;
}

.image-listview.media .simple-listview {
  padding-left: 80px !important;
}
.image-listview.media .link-listview a,
.image-listview.media .link-listview .item,
.image-listview.media .image-listview a,
.image-listview.media .image-listview .item {
  padding-left: 96px !important;
}

.card {
  background: #53AAC6;
  border-radius: 24px;
  border: 0;
  box-shadow: 0px 4px 4px rgba(0, 0, 0, 0.25);
}
.card .card-body {
  padding: 24px 16px;
  line-height: 1.4em;
}
.card .card-title {
  text-align: center;
  color: #ffffff;
  font-size: 24px;
  font-weight: 700;
}
.card .card-subtitle {
  color: #ffffff;
  font-weight: 500;
  letter-spacing: 0.01em;
  font-size: 11px;
  text-transform: uppercase;
  margin-bottom: 8px;
  margin-top: -4px;
}
.card .listview > li:first-child .item {
  border-radius: 24px 24px 0 0;
}
.card .listview > li:last-child .item {
  border-radius: 0 0 24px 24px;
}
.card .card-header {
  background: transparent;
  color: #ffffff;
  font-weight: 500;
  padding: 12px 16px;
  border-bottom: 1px solid #E1E1E1;
}
.card .card-vcc {
  background: #2E2481;
}
.card .card-footer {
  background: transparent;
  border-top: 1px solid #E1E1E1;
  color: #4F5050;
  padding: 12px 16px;
}
.card .card-img-top {
  border-radius: 24px 24px 0 0;
}
.card .overlay-img {
  border-radius: 24px;
}
.card .card-img-overlay {
  background: rgba(0, 0, 0, 0.5);
  border-radius: 24px;
}
.card .card-img-overlay .card-title {
  color: #fff;
}
.card .card-img-overlay .card-text {
  color: rgba(255, 255, 255, 0.7);
}
.card.bg-primary, .card.bg-secondary, .card.bg-danger, .card.bg-success, .card.bg-warning, .card.bg-info, .card.bg-dark {
  border: 0;
}
.card.bg-primary .card-title, .card.bg-secondary .card-title, .card.bg-danger .card-title, .card.bg-success .card-title, .card.bg-warning .card-title, .card.bg-info .card-title, .card.bg-dark .card-title {
  color: #fff;
}
.card.bg-primary .card-text, .card.bg-secondary .card-text, .card.bg-danger .card-text, .card.bg-success .card-text, .card.bg-warning .card-text, .card.bg-info .card-text, .card.bg-dark .card-text {
  color: rgba(255, 255, 255, 0.7);
}
.card.bg-primary .card-header, .card.bg-secondary .card-header, .card.bg-danger .card-header, .card.bg-success .card-header, .card.bg-warning .card-header, .card.bg-info .card-header, .card.bg-dark .card-header {
  color: #fff;
  border-bottom: 1px solid rgba(255, 255, 255, 0.15);
}
.card.bg-light {
  background: #fff;
}

.card.product-card .card-body {
  padding: 8px;
}
.card.product-card .image {
  width: 100%;
  border-radius: 24px;
}
.card.product-card .title {
  font-size: 15px;
  margin: 10px 0 0 0;
  padding: 0 4px;
  font-weight: 500;
}
.card.product-card .text {
  font-size: 11px;
  color: #939393;
  margin: 0;
  padding: 0 4px 10px 4px;
}
.card.product-card .price {
  margin: 0 0 10px 0;
  padding: 0px 4px;
  display: block;
  font-size: 15px;
  font-weight: 500;
  color: #2E2481;
}

.btn {
  height: 50px;
  padding: 20px 50px;
  font-size: 13px;
  line-height: 1.2em;
  font-weight: 500;
  box-shadow: none !important;
  display: inline-flex;
  align-items: center;
  justify-content: center;
  transition: none;
  text-decoration: none !important;
  border-radius: 24px;
  border-width: 2px;
}
.btn i.bi,
.btn i.icon,
.btn ion-icon {
  font-size: 22px;
  margin-right: 10px;
  margin-top: -2px;
  font-weight: 700;
}
.btn.rounded {
  border-radius: 100px !important;
}
.btn.square {
  border-radius: 0 !important;
}
.btn.shadowed {
  box-shadow: 0px 4px 4px rgba(0, 0, 0, 0.25) !important;
}

.btn-lg {
  height: 60px;
  padding: 3px 24px;
  font-size: 18px;
}
.btn-lg i.bi,
.btn-lg i.icon,
.btn-lg ion-icon {
  font-size: 26px;
}

.btn-sm {
  height: 30px;
  padding: 0px 12px;
  font-size: 12px;
}
.btn-sm i.bi,
.btn-sm i.icon,
.btn-sm ion-icon {
  font-size: 20px;
  margin-right: 6px;
}

.btn-block {
  width: 100%;
}

.btn-group .btn:active {
  transform: none;
}

.btn-icon {
  width: 40px;
  height: 40px;
  padding: 0;
}
.btn-icon i.bi,
.btn-icon i.icon,
.btn-icon ion-icon {
  text-align: center;
  margin: 0 !important;
}
.btn-icon.btn-lg {
  width: 48px;
  height: 48px;
}
.btn-icon.btn-lg i.bi,
.btn-icon.btn-lg i.icon,
.btn-icon.btn-lg ion-icon {
  font-size: 32px;
}
.btn-icon.btn-sm {
  width: 30px;
  height: 30px;
}
.btn-icon.btn-sm i.bi,
.btn-icon.btn-sm i.icon,
.btn-icon.btn-sm ion-icon {
  font-size: 18px;
}

.btn-primary {
  background: #2E2481 !important;
  border-color: #2E2481 !important;
  color: #ffffff !important;
}
.btn-primary:hover, .btn-primary:focus, .btn-primary:active, .btn-primary.active {
  background: #271e6d !important;
  border-color: #271e6d !important;
}
.btn-primary.disabled, .btn-primary:disabled {
  background: #2E2481;
  border-color: #2E2481;
  opacity: 0.5;
}

.btn-secondary {
  background: #53AAC6 !important;
  border-color: #53AAC6 !important;
  color: #ffffff !important;
}
.btn-secondary:hover, .btn-secondary:focus, .btn-secondary:active, .btn-secondary.active {
  background: #40a1c0 !important;
  border-color: #40a1c0 !important;
}
.btn-secondary.disabled, .btn-secondary:disabled {
  background: #53AAC6;
  border-color: #53AAC6;
  opacity: 0.5;
}

.btn-success {
  background: #C7FB93 !important;
  border-color: #C7FB93 !important;
  color: #ffffff !important;
}
.btn-success:hover, .btn-success:focus, .btn-success:active, .btn-success.active {
  background: #bafa7a !important;
  border-color: #bafa7a !important;
}
.btn-success.disabled, .btn-success:disabled {
  background: #C7FB93;
  border-color: #C7FB93;
  opacity: 0.5;
}

.btn-danger {
  background: #FB9393 !important;
  border-color: #FB9393 !important;
  color: #ffffff !important;
}
.btn-danger:hover, .btn-danger:focus, .btn-danger:active, .btn-danger.active {
  background: #fa7a7a !important;
  border-color: #fa7a7a !important;
}
.btn-danger.disabled, .btn-danger:disabled {
  background: #FB9393;
  border-color: #FB9393;
  opacity: 0.5;
}

.btn-warning {
  color: #fff !important;
  background: #FBC593 !important;
  border-color: #FBC593 !important;
  color: #ffffff !important;
}
.btn-warning:hover, .btn-warning:focus, .btn-warning:active, .btn-warning.active {
  background: #fab87a !important;
  border-color: #fab87a !important;
}
.btn-warning.disabled, .btn-warning:disabled {
  background: #FBC593;
  border-color: #FBC593;
  opacity: 0.5;
}

.btn-link {
  color: #2E2481 !important;
}

.btn-info {
  background: #ffffff !important;
  border-color: #ffffff !important;
  color: #ffffff !important;
}
.btn-info:hover, .btn-info:focus, .btn-info:active, .btn-info.active {
  background: #f2f2f2 !important;
  border-color: #f2f2f2 !important;
}
.btn-info.disabled, .btn-info:disabled {
  background: #ffffff;
  border-color: #ffffff;
  opacity: 0.5;
}

.btn-dark {
  background: #333 !important;
  border-color: #333 !important;
  color: #ffffff !important;
}
.btn-dark:hover, .btn-dark:focus, .btn-dark:active, .btn-dark.active {
  background: #262626 !important;
  border-color: #262626 !important;
}
.btn-dark.disabled, .btn-dark:disabled {
  background: #333;
  border-color: #333;
  opacity: 0.5;
}

.btn-light {
  background: rgba(255, 255, 255, 0.5) !important;
  border-color: rgba(255, 255, 255, 0.5) !important;
  color: #ffffff !important;
  color: #1c1b1b !important;
}
.btn-light:hover, .btn-light:focus, .btn-light:active, .btn-light.active {
  background: rgba(242, 242, 242, 0.5) !important;
  border-color: rgba(242, 242, 242, 0.5) !important;
}
.btn-light.disabled, .btn-light:disabled {
  background: rgba(255, 255, 255, 0.5);
  border-color: rgba(255, 255, 255, 0.5);
  opacity: 0.5;
}

.btn-outline-primary {
  background: transparent;
  border-color: #2E2481;
  border-width: 1px !important;
  color: #2E2481;
  transition: none;
}
.btn-outline-primary:hover, .btn-outline-primary:active {
  background: rgba(46, 36, 129, 0.15) !important;
  border-color: #2E2481 !important;
  color: #2E2481 !important;
}
.btn-outline-primary.active {
  background: #2E2481 !important;
  color: #fff !important;
  border-color: #2E2481 !important;
}
.btn-outline-primary.disabled, .btn-outline-primary:disabled {
  color: #2E2481 !important;
  border-color: #2E2481 !important;
  background: transparent !important;
  opacity: 0.5;
}

.btn-outline-secondary {
  background: transparent;
  border-color: #53AAC6;
  border-width: 1px !important;
  color: #53AAC6;
  transition: none;
}
.btn-outline-secondary:hover, .btn-outline-secondary:active {
  background: rgba(83, 170, 198, 0.15) !important;
  border-color: #53AAC6 !important;
  color: #53AAC6 !important;
}
.btn-outline-secondary.active {
  background: #53AAC6 !important;
  color: #fff !important;
  border-color: #53AAC6 !important;
}
.btn-outline-secondary.disabled, .btn-outline-secondary:disabled {
  color: #53AAC6 !important;
  border-color: #53AAC6 !important;
  background: transparent !important;
  opacity: 0.5;
}

.btn-outline-success {
  background: transparent;
  border-color: #C7FB93;
  border-width: 1px !important;
  color: #C7FB93;
  transition: none;
}
.btn-outline-success:hover, .btn-outline-success:active {
  background: rgba(199, 251, 147, 0.15) !important;
  border-color: #C7FB93 !important;
  color: #C7FB93 !important;
}
.btn-outline-success.active {
  background: #C7FB93 !important;
  color: #fff !important;
  border-color: #C7FB93 !important;
}
.btn-outline-success.disabled, .btn-outline-success:disabled {
  color: #C7FB93 !important;
  border-color: #C7FB93 !important;
  background: transparent !important;
  opacity: 0.5;
}

.btn-outline-danger {
  background: transparent;
  border-color: #FB9393;
  border-width: 1px !important;
  color: #FB9393;
  transition: none;
}
.btn-outline-danger:hover, .btn-outline-danger:active {
  background: rgba(251, 147, 147, 0.15) !important;
  border-color: #FB9393 !important;
  color: #FB9393 !important;
}
.btn-outline-danger.active {
  background: #FB9393 !important;
  color: #fff !important;
  border-color: #FB9393 !important;
}
.btn-outline-danger.disabled, .btn-outline-danger:disabled {
  color: #FB9393 !important;
  border-color: #FB9393 !important;
  background: transparent !important;
  opacity: 0.5;
}

.btn-outline-warning {
  background: transparent;
  border-color: #FBC593;
  border-width: 1px !important;
  color: #FBC593;
  transition: none;
}
.btn-outline-warning:hover, .btn-outline-warning:active {
  background: rgba(251, 197, 147, 0.15) !important;
  border-color: #FBC593 !important;
  color: #FBC593 !important;
}
.btn-outline-warning.active {
  background: #FBC593 !important;
  color: #fff !important;
  border-color: #FBC593 !important;
}
.btn-outline-warning.disabled, .btn-outline-warning:disabled {
  color: #FBC593 !important;
  border-color: #FBC593 !important;
  background: transparent !important;
  opacity: 0.5;
}

.btn-outline-info {
  background: transparent;
  border-color: #ffffff;
  border-width: 1px !important;
  color: #ffffff;
  transition: none;
}
.btn-outline-info:hover, .btn-outline-info:active {
  background: rgba(255, 255, 255, 0.15) !important;
  border-color: #ffffff !important;
  color: #ffffff !important;
}
.btn-outline-info.active {
  background: #ffffff !important;
  color: #fff !important;
  border-color: #ffffff !important;
}
.btn-outline-info.disabled, .btn-outline-info:disabled {
  color: #ffffff !important;
  border-color: #ffffff !important;
  background: transparent !important;
  opacity: 0.5;
}

.btn-outline-light {
  background: transparent;
  border-color: #fff;
  border-width: 1px !important;
  color: #fff;
  transition: none;
}
.btn-outline-light:hover, .btn-outline-light:active {
  background: rgba(255, 255, 255, 0.15) !important;
  border-color: #fff !important;
  color: #fff !important;
}
.btn-outline-light.active {
  background: #fff !important;
  color: #fff !important;
  border-color: #fff !important;
}
.btn-outline-light.disabled, .btn-outline-light:disabled {
  color: #fff !important;
  border-color: #fff !important;
  background: transparent !important;
  opacity: 0.5;
}
.btn-outline-light:active {
  color: #1c1b1b !important;
}

.btn-outline-dark {
  border-width: 1px;
}

.btn-text-primary {
  background: transparent;
  border-color: transparent;
  color: #2E2481 !important;
  transition: none;
}
.btn-text-primary:hover {
  background: transparent;
}
.btn-text-primary:active, .btn-text-primary.active {
  background: rgba(46, 36, 129, 0.15) !important;
  border-color: transparent !important;
  color: #2E2481 !important;
}
.btn-text-primary.disabled, .btn-text-primary:disabled {
  color: #2E2481 !important;
  border-color: #2E2481 !important;
  background: transparent !important;
  opacity: 0.5;
}

.btn-text-secondary {
  background: transparent;
  border-color: transparent;
  color: #53AAC6 !important;
  transition: none;
}
.btn-text-secondary:hover {
  background: transparent;
}
.btn-text-secondary:active, .btn-text-secondary.active {
  background: rgba(83, 170, 198, 0.15) !important;
  border-color: transparent !important;
  color: #53AAC6 !important;
}
.btn-text-secondary.disabled, .btn-text-secondary:disabled {
  color: #53AAC6 !important;
  border-color: #53AAC6 !important;
  background: transparent !important;
  opacity: 0.5;
}

.btn-text-success {
  background: transparent;
  border-color: transparent;
  color: #C7FB93 !important;
  transition: none;
}
.btn-text-success:hover {
  background: transparent;
}
.btn-text-success:active, .btn-text-success.active {
  background: rgba(199, 251, 147, 0.15) !important;
  border-color: transparent !important;
  color: #C7FB93 !important;
}
.btn-text-success.disabled, .btn-text-success:disabled {
  color: #C7FB93 !important;
  border-color: #C7FB93 !important;
  background: transparent !important;
  opacity: 0.5;
}

.btn-text-danger {
  background: transparent;
  border-color: transparent;
  color: #FB9393 !important;
  transition: none;
}
.btn-text-danger:hover {
  background: transparent;
}
.btn-text-danger:active, .btn-text-danger.active {
  background: rgba(251, 147, 147, 0.15) !important;
  border-color: transparent !important;
  color: #FB9393 !important;
}
.btn-text-danger.disabled, .btn-text-danger:disabled {
  color: #FB9393 !important;
  border-color: #FB9393 !important;
  background: transparent !important;
  opacity: 0.5;
}

.btn-text-warning {
  background: transparent;
  border-color: transparent;
  color: #FBC593 !important;
  transition: none;
}
.btn-text-warning:hover {
  background: transparent;
}
.btn-text-warning:active, .btn-text-warning.active {
  background: rgba(251, 197, 147, 0.15) !important;
  border-color: transparent !important;
  color: #FBC593 !important;
}
.btn-text-warning.disabled, .btn-text-warning:disabled {
  color: #FBC593 !important;
  border-color: #FBC593 !important;
  background: transparent !important;
  opacity: 0.5;
}

.btn-text-info {
  background: transparent;
  border-color: transparent;
  color: #ffffff !important;
  transition: none;
}
.btn-text-info:hover {
  background: transparent;
}
.btn-text-info:active, .btn-text-info.active {
  background: rgba(255, 255, 255, 0.15) !important;
  border-color: transparent !important;
  color: #ffffff !important;
}
.btn-text-info.disabled, .btn-text-info:disabled {
  color: #ffffff !important;
  border-color: #ffffff !important;
  background: transparent !important;
  opacity: 0.5;
}

.btn-text-light {
  background: transparent;
  color: #fff;
}
.btn-text-light:hover, .btn-text-light:active, .btn-text-light.active {
  color: #fff;
  background: rgba(255, 255, 255, 0.1);
}

.btn-text-dark {
  background: transparent;
  border-color: transparent;
  color: #1c1b1b !important;
  transition: none;
}
.btn-text-dark:hover {
  background: transparent;
}
.btn-text-dark:active, .btn-text-dark.active {
  background: rgba(28, 27, 27, 0.15) !important;
  border-color: transparent !important;
  color: #1c1b1b !important;
}
.btn-text-dark.disabled, .btn-text-dark:disabled {
  color: #1c1b1b !important;
  border-color: #1c1b1b !important;
  background: transparent !important;
  opacity: 0.5;
}

.btn-group .btn {
  margin-left: -1px !important;
}

.btn-facebook {
  color: #fff !important;
  background: #39579b;
}
.btn-facebook:hover, .btn-facebook:active {
  background: #324d88;
}

.bg-facebook {
  background: #39579b;
  color: #fff !important;
}

.btn-twitter {
  color: #fff !important;
  background: #049ff6;
}
.btn-twitter:hover, .btn-twitter:active {
  background: #048fdd;
}

.bg-twitter {
  background: #049ff6;
  color: #fff !important;
}

.btn-instagram {
  color: #fff !important;
  background: #df237b;
}
.btn-instagram:hover, .btn-instagram:active {
  background: #cb1e6f;
}

.bg-instagram {
  background: #de0067;
  color: #fff !important;
}

.btn-linkedin {
  color: #fff !important;
  background: #0075aa;
}
.btn-linkedin:hover, .btn-linkedin:active {
  background: #006391;
}

.bg-linkedin {
  background: #0075aa;
  color: #fff !important;
}

.btn-twitch {
  color: #fff !important;
  background: #923cff;
}
.btn-twitch:hover, .btn-twitch:active {
  background: #8423ff;
}

.bg-twitch {
  background: #923cff;
  color: #fff !important;
}

.btn-whatsapp {
  color: #fff !important;
  background: #0ad561;
}
.btn-whatsapp:hover, .btn-whatsapp:active {
  background: #09bd56;
}

.bg-whatsapp {
  background: #0ad561;
  color: #fff !important;
}

.btn-youtube {
  color: #fff !important;
  background: #ff0000;
}
.btn-youtube:hover, .btn-youtube:active {
  background: #e60000;
}

.bg-youtube {
  background: #ff0000;
  color: #fff !important;
}

.btn-amazon {
  color: #fff !important;
  background: #292929;
}
.btn-amazon:hover, .btn-amazon:active {
  background: #1c1c1c;
}

.bg-amazon {
  background: #292929;
  color: #fff !important;
}

.btn-android {
  color: #fff !important;
  background: #7dd159;
}
.btn-android:hover, .btn-android:active {
  background: #6dcb45;
}

.bg-android {
  background: #7dd159;
  color: #fff !important;
}

.btn-apple {
  color: #fff !important;
  background: #000;
}
.btn-apple:hover, .btn-apple:active {
  background: #222;
}

.bg-apple {
  background: #000;
  color: #fff !important;
}

.btn-dribbble {
  color: #fff !important;
  background: #ec4989;
}
.btn-dribbble:hover, .btn-dribbble:active {
  background: #ea327a;
}

.bg-dribbble {
  background: #ec4989;
  color: #fff !important;
}

.btn-skype {
  color: #fff !important;
  background: #00a8f3;
}
.btn-skype:hover, .btn-skype:active {
  background: #0096da;
}

.bg-skype {
  background: #00a8f3;
  color: #fff !important;
}

.btn-pinterest {
  color: #fff !important;
  background: #f12a2c;
}
.btn-pinterest:hover, .btn-pinterest:active {
  background: #ef1214;
}

.bg-pinterest {
  background: #f12a2c;
  color: #fff !important;
}

.btn-dropbox {
  color: #fff !important;
  background: #005cff;
}
.btn-dropbox:hover, .btn-dropbox:active {
  background: #0053e6;
}

.bg-dropbox {
  background: #005cff;
  color: #fff !important;
}

.btn-bitcoin {
  color: #fff !important;
  background: #f99400;
}
.btn-bitcoin:hover, .btn-bitcoin:active {
  background: #e08500;
}

.bg-bitcoin {
  background: #f99400;
  color: #fff !important;
}

.btn-github {
  color: #fff !important;
  background: #323131;
}
.btn-github:hover, .btn-github:active {
  background: #252424;
}

.bg-github {
  background: #323131;
  color: #fff !important;
}

.btn-check:checked + .btn-outline-primary,
.btn-check:checked + .btn-outline-secondary,
.btn-check:checked + .btn-outline-danger,
.btn-check:checked + .btn-outline-warning,
.btn-check:checked + .btn-outline-success,
.btn-check:checked + .btn-outline-info,
.btn-check:checked + .btn-outline-dark {
  color: #fff !important;
  transition: none;
}

.btn-check:checked + .btn-outline-primary {
  background: #2E2481 !important;
  border-color: #2E2481 !important;
}

.btn-check:checked + .btn-outline-secondary {
  background: #53AAC6 !important;
  border-color: #53AAC6 !important;
}

.btn-check:checked + .btn-outline-warning {
  background: #FBC593 !important;
  border-color: #FBC593 !important;
}

.btn-check:checked + .btn-outline-danger {
  background: #FB9393 !important;
  border-color: #FB9393 !important;
}

.btn-check:checked + .btn-outline-success {
  background: #C7FB93 !important;
  border-color: #C7FB93 !important;
}

.btn-check:checked + .btn-outline-info {
  background: #ffffff !important;
  border-color: #ffffff !important;
}

.btn-check:checked + .btn-outline-dark {
  background: #222 !important;
  border-color: #222 !important;
}

.accordion {
  border-top: 1px solid #E1E1E1;
  border-bottom: 1px solid #E1E1E1;
  background: #fff;
}
.accordion.accordion-flush {
  background: transparent;
}
.accordion .accordion-collapse {
  border: 0;
}
.accordion .accordion-item {
  border: 0;
}
.accordion .accordion-body {
  padding: 8px 16px 20px 16px;
}
.accordion .accordion-content {
  padding: 0;
}
.accordion .accordion-header {
  position: relative;
}
.accordion .accordion-header .btn,
.accordion .accordion-header .accordion-button {
  box-shadow: none !important;
  justify-content: flex-start !important;
  border-radius: 0 !important;
  width: 100%;
  text-align: left !important;
  font-weight: 400;
  background: transparent !important;
  font-size: 15px;
  padding: 8px 50px 8px 16px;
  border: 0 !important;
  min-height: 50px;
  color: #1c1b1b;
}
.accordion .accordion-header .btn:active,
.accordion .accordion-header .accordion-button:active {
  background: rgba(225, 225, 225, 0.3) !important;
}
.accordion .accordion-header .btn:after,
.accordion .accordion-header .accordion-button:after {
  background: url("data:image/svg+xml,%0A%3Csvg width='10px' height='16px' viewBox='0 0 10 16' version='1.1' xmlns='http://www.w3.org/2000/svg' xmlns:xlink='http://www.w3.org/1999/xlink'%3E%3Cg id='Page-1' stroke='none' stroke-width='1' fill='none' fill-rule='evenodd' stroke-linecap='round' stroke-linejoin='round'%3E%3Cg id='Listview' transform='translate(-112.000000, -120.000000)' stroke='%23939393' stroke-width='2.178'%3E%3Cpolyline id='Path' points='114 122 120 128 114 134'%3E%3C/polyline%3E%3C/g%3E%3C/g%3E%3C/svg%3E") no-repeat center center !important;
  content: "";
  width: 20px;
  height: 20px;
  font-weight: 700;
  position: absolute;
  right: 10px;
  color: #939393;
  line-height: 1em;
  transition: 0s all;
  height: 18px;
  top: 50%;
  opacity: 0.5;
  margin-top: -9px;
  transform: rotate(-90deg);
}
.accordion .accordion-header .btn:before,
.accordion .accordion-header .accordion-button:before {
  content: "";
  display: block;
  height: 1px;
  background: transparent;
  position: absolute;
  left: 16px;
  bottom: 1px;
  right: 0;
}
.accordion .accordion-header .btn.collapsed:after,
.accordion .accordion-header .accordion-button.collapsed:after {
  transform: rotate(90deg);
}
.accordion .accordion-header .btn.collapsed:before,
.accordion .accordion-header .accordion-button.collapsed:before {
  background: #E1E1E1;
}
.accordion .accordion-header .btn i.bi,
.accordion .accordion-header .btn i.icon,
.accordion .accordion-header .btn ion-icon,
.accordion .accordion-header .accordion-button i.bi,
.accordion .accordion-header .accordion-button i.icon,
.accordion .accordion-header .accordion-button ion-icon {
  width: 24px;
  font-size: 24px;
  margin-right: 10px;
  display: flex;
  align-items: center;
  justify-content: center;
}
.accordion .accordion-item:first-child {
  border-radius: 24px 24px 0 0;
}
.accordion .accordion-item:last-child {
  border-radius: 0 0 24px 24px;
}
.accordion .accordion-item:last-child .accordion-header .accordion-button:before {
  display: none;
}

.inset .accordion {
  border-radius: 24px;
  border: 1px solid #E1E1E1;
}
.inset .accordion .accordion-item:first-child .btn {
  border-radius: 24px 24px 0 0 !important;
}
.inset .accordion .accordion-item:last-child .btn {
  border-radius: 0 0 24px 24px !important;
}

.offcanvas.action-sheet {
  border: 0;
  height: auto;
  z-index: 9999;
}
.offcanvas.action-sheet .offcanvas-body {
  padding: 0;
}
.offcanvas.action-sheet .offcanvas-body .action-sheet-content {
  padding: 20px 16px;
  max-height: 460px;
  overflow: auto;
}
.offcanvas.action-sheet .offcanvas-header {
  padding: 2px 20px;
  display: block;
  min-height: auto;
  box-shadow: none;
  border-bottom: 1px solid #E1E1E1;
}
.offcanvas.action-sheet .offcanvas-header .offcanvas-title {
  padding: 0;
  margin: 0;
  text-align: center;
  display: block;
  font-size: 13px;
  padding: 6px 0;
  color: #1c1b1b;
  font-weight: 500;
}
.offcanvas.action-sheet .offcanvas-header .close-button {
  font-size: 20px;
  color: #939393;
  position: absolute;
  right: 0;
  top: 2px;
  width: 48px;
  height: 32px;
  display: flex;
  align-items: center;
  justify-content: center;
}
.offcanvas.action-sheet .offcanvas-header .close-button:hover, .offcanvas.action-sheet .offcanvas-header .close-button:active {
  opacity: 0.7;
}

.offcanvas.action-sheet.inset {
  left: 16px;
  right: 16px;
  width: auto;
  bottom: 16px;
  border-radius: 16px;
  padding-bottom: 0;
  margin-bottom: env(safe-area-inset-bottom);
}
.offcanvas.action-sheet.inset .action-button-list > li:last-child .btn {
  border-radius: 0 0 16px 16px !important;
}

.action-button-list {
  padding: 0;
  margin: 0;
}
.action-button-list > li {
  display: block;
}
.action-button-list > li .btn {
  padding: 0;
  display: flex;
  width: 100%;
  min-height: 50px;
  font-size: 15px;
  color: #1c1b1b;
  line-height: 1.1em;
  justify-content: space-between;
  font-weight: 400;
  border-radius: 0 !important;
  padding: 10px 16px;
}
.action-button-list > li .btn:active, .action-button-list > li .btn.active {
  background: rgba(225, 225, 225, 0.3);
}
.action-button-list > li .btn.text-primary {
  color: #2E2481 !important;
}
.action-button-list > li .btn.text-secondary {
  color: #53AAC6 !important;
}
.action-button-list > li .btn.text-danger {
  color: #FB9393 !important;
}
.action-button-list > li .btn.text-success {
  color: #C7FB93 !important;
}
.action-button-list > li .btn.text-warning {
  color: #FBC593 !important;
}
.action-button-list > li .btn.text-info {
  color: #ffffff !important;
}
.action-button-list > li .btn.text-light {
  color: #fff !important;
}
.action-button-list > li .btn.text-dark {
  color: #1c1b1b !important;
}
.action-button-list > li .btn > span {
  display: flex;
  align-items: center;
  justify-content: flex-start;
}
.action-button-list > li .btn i.bi,
.action-button-list > li .btn i.icon,
.action-button-list > li .btn ion-icon {
  width: 24px !important;
  height: 24px;
  display: inline-flex;
  align-items: center;
  justify-content: center;
  margin-right: 10px;
  margin-left: -5px;
  font-size: 24px;
  line-height: 1em;
}
.action-button-list > li.action-divider {
  height: 1px;
  background: #E1E1E1;
}

.dialogbox .modal-dialog {
  position: fixed;
  left: 0;
  top: 0;
  bottom: 0;
  right: 0;
  z-index: 12000;
  display: flex;
  overflow: auto;
  align-items: center;
  justify-content: center;
  transform: translate(0, 0) !important;
  transform: scale(0.8) !important;
}
.dialogbox .modal-dialog .form-group {
  text-align: left;
}
.dialogbox .modal-dialog .modal-content {
  max-width: 300px;
  margin: auto;
  max-height: 560px;
  overflow: auto;
  border: 0;
  border-radius: 16px;
}
.dialogbox .modal-dialog .modal-content .btn-list {
  margin: 0;
}
.dialogbox .modal-dialog .modal-content .btn-list .btn {
  padding: 0px 10px;
  min-height: 58px;
  border-radius: 0;
  margin: 0;
  border: 0;
  border-bottom: 1px solid #E1E1E1 !important;
  font-size: 15px;
}
.dialogbox .modal-dialog .modal-content .btn-list .btn:hover, .dialogbox .modal-dialog .modal-content .btn-list .btn:focus, .dialogbox .modal-dialog .modal-content .btn-list .btn:active, .dialogbox .modal-dialog .modal-content .btn-list .btn.active {
  background: rgba(225, 225, 225, 0.3) !important;
}
.dialogbox .modal-dialog .modal-content .btn-list .btn:last-child {
  border-radius: 0 0 16px 16px;
  border-bottom: 0 !important;
}
.dialogbox .modal-dialog .modal-content .btn-inline {
  display: flex;
  margin: 0;
  background: #E1E1E1;
}
.dialogbox .modal-dialog .modal-content .btn-inline .btn {
  width: 100%;
  border-radius: 0;
  min-height: 58px;
  border: 0 !important;
  font-size: 15px;
  margin-right: 1px;
  background: #FFF;
}
.dialogbox .modal-dialog .modal-content .btn-inline .btn:hover, .dialogbox .modal-dialog .modal-content .btn-inline .btn:focus, .dialogbox .modal-dialog .modal-content .btn-inline .btn:active, .dialogbox .modal-dialog .modal-content .btn-inline .btn.active {
  background: rgba(255, 255, 255, 0.8) !important;
}
.dialogbox .modal-dialog .modal-content .btn-inline .btn:last-child {
  margin-right: 0;
  border-radius: 0 0 16px 0 !important;
}
.dialogbox .modal-dialog .modal-content .btn-inline .btn:first-child {
  border-radius: 0 0 0 16px !important;
}
.dialogbox .modal-dialog .modal-content .modal-header {
  border: 0;
  padding: 20px 20px 10px 20px;
}
.dialogbox .modal-dialog .modal-content .modal-header .modal-title {
  color: #1c1b1b;
  text-align: center;
  margin: 0 auto;
  font-size: 17px;
}
.dialogbox .modal-dialog .modal-content .modal-body {
  padding: 0 20px;
  margin-bottom: 30px;
  text-align: center;
  font-size: 15px;
}
.dialogbox .modal-dialog .modal-content .modal-footer {
  border: 0;
  border-top: 1px solid #E1E1E1;
  padding: 0;
  display: block;
  text-align: right;
}
.dialogbox.show .modal-dialog {
  transform: translate(0, 0) !important;
  transform: scale(1) !important;
}

.modal-icon {
  font-size: 60px;
  line-height: 1em;
  margin-top: 30px;
  margin-bottom: -10px;
  color: #2E2481;
  text-align: center;
}

.modalbox {
  padding-top: env(safe-area-inset-top);
  overflow: hidden;
}
.modalbox .modal-dialog {
  transform: translate(0, 100%) !important;
  min-width: 100%;
  margin: 0;
  transition: 0.5s all !important;
  position: fixed;
  left: 0;
  top: 0;
  right: 0;
  bottom: 0;
  margin-top: env(safe-area-inset-top);
}
.modalbox .modal-dialog .modal-content {
  border-radius: 0;
  border: 0;
  margin: auto;
  overflow: hidden;
  padding-top: 56px;
  position: absolute;
  left: 0;
  right: 0;
  bottom: 0;
  top: 0;
}
.modalbox .modal-dialog .modal-content .modal-header {
  border: 0;
  padding: 0;
  min-height: 56px;
  padding: 10px 16px;
  border-radius: 0;
  display: flex;
  border-bottom: 1px solid #E1E1E1;
  align-items: center;
  justify-content: space-between;
  margin: 0;
  position: fixed;
  left: 0;
  right: 0;
  top: 0;
  width: 100%;
  z-index: 100;
  background: #FFF;
}
.modalbox .modal-dialog .modal-content .modal-header .modal-title {
  margin: 0;
  color: #1c1b1b;
  font-size: 17px;
}
.modalbox .modal-dialog .modal-content .modal-body {
  padding: 20px 16px;
  overflow: auto;
}
.modalbox.show .modal-dialog {
  transform: translate(0, 0) !important;
}

.offcanvas {
  width: 300px;
  border: 0;
}
.offcanvas .offcanvas-header {
  box-shadow: 0px 4px 4px rgba(0, 0, 0, 0.25);
  min-height: 56px;
  padding: 10px 16px;
}
.offcanvas .offcanvas-header .offcanvas-title {
  font-size: 15px;
  font-weight: 500;
}
.offcanvas .offcanvas-header .offcanvas-close {
  color: #2E2481;
  margin: 0;
  display: flex;
  align-items: center;
  justify-content: center;
}
.offcanvas .offcanvas-header .offcanvas-close i.bi,
.offcanvas .offcanvas-header .offcanvas-close i.icon,
.offcanvas .offcanvas-header .offcanvas-close ion-icon {
  font-size: 26px;
}
.offcanvas .offcanvas-body {
  padding: 16px;
}

.offcanvas-start,
.offcanvas-end,
.offcanvas-top {
  padding-top: env(safe-area-inset-top);
}

.offcanvas-top {
  transform: translateY(-120%);
}

.offcanvas-bottom {
  padding-bottom: env(safe-area-inset-bottom);
  transform: translateY(120%);
}

.offcanvas-top,
.offcanvas-bottom {
  width: 100%;
  height: 40vh;
}

.cookies-modal {
  background: #FFF;
  border-radius: 24px;
  box-shadow: 0px 4px 4px rgba(0, 0, 0, 0.25);
  border: 1px solid #E1E1E1;
  position: fixed;
  z-index: 100;
  bottom: 72px;
  left: 16px;
  right: 16px;
  padding: 16px;
  font-size: 13px;
  line-height: 1.56em;
  transform: translate(0%, 150%);
  transition: 0.4s ease-in-out;
}
.cookies-modal .title {
  font-size: 15px;
  line-height: 1.7em;
}
.cookies-modal.show {
  transform: translate(0%, 0%);
}

.tooltip .tooltip-inner {
  font-size: 13px;
  padding: 6px 10px;
  border-radius: 24px;
}

.dropdown .dropdown-menu,
.dropup .dropdown-menu {
  border: 1px solid transparent;
  min-width: 120px;
  padding: 8px 0;
  border-radius: 24px;
  box-shadow: 0px 4px 4px rgba(0, 0, 0, 0.25);
  margin-top: 3px !important;
}
.dropdown .dropdown-menu .dropdown-item,
.dropup .dropdown-menu .dropdown-item {
  padding: 12px 16px;
  line-height: 1.2em;
  color: #1c1b1b;
  font-size: 15px;
  display: flex;
  align-items: center;
}
.dropdown .dropdown-menu .dropdown-item:hover, .dropdown .dropdown-menu .dropdown-item:active,
.dropup .dropdown-menu .dropdown-item:hover,
.dropup .dropdown-menu .dropdown-item:active {
  background: rgba(225, 225, 225, 0.5);
  color: #1c1b1b;
}
.dropdown .dropdown-menu .dropdown-divider,
.dropup .dropdown-menu .dropdown-divider {
  border-top: 1px solid #E1E1E1;
}
.dropdown .dropdown-menu .dropdown-header,
.dropup .dropdown-menu .dropdown-header {
  padding: 9px 16px;
  color: #4F5050;
  font-weight: 400;
  font-size: 11px;
}
.dropdown .dropdown-menu .text,
.dropup .dropdown-menu .text {
  padding: 9px 16px;
  color: #4F5050;
}
.dropdown .dropdown-menu i.bi,
.dropdown .dropdown-menu i.icon,
.dropdown .dropdown-menu ion-icon,
.dropup .dropdown-menu i.bi,
.dropup .dropdown-menu i.icon,
.dropup .dropdown-menu ion-icon {
  margin-right: 10px;
  width: 22px;
  height: 22px;
  font-size: 22px;
  justify-content: center;
  align-items: center;
  line-height: 1em;
  display: inline-flex;
  color: #1c1b1b;
}

.appHeader .dropdown-menu {
  margin-top: -10px !important;
}

.dropdown-toggle:after {
  border-radius: 4px;
  margin-left: 7px;
}

.bg-primary {
  background: #2E2481 !important;
  color: #FFF;
}

.bg-secondary {
  background: #53AAC6 !important;
  color: #FFF;
}

.bg-success {
  background: #C7FB93 !important;
  color: #FFF;
}

.bg-danger {
  background: #FB9393 !important;
  color: #FFF;
}

.bg-warning {
  background: #FBC593 !important;
  color: #FFF;
}

.bg-info {
  background: #ffffff !important;
  color: #FFF;
}

.bg-light {
  background: rgba(255, 255, 255, 0.5) !important;
}

.bg-dark {
  background: #222 !important;
  color: #FFF;
}

a.bg-primary {
  background: #2E2481 !important;
  color: #FFF !important;
}
a.bg-primary:hover, a.bg-primary:active {
  background: #271e6d !important;
}

a.bg-secondary {
  background: #53AAC6 !important;
  color: #FFF !important;
}
a.bg-secondary:hover, a.bg-secondary:active {
  background: #40a1c0 !important;
}

a.bg-success {
  background: #C7FB93 !important;
  color: #FFF !important;
}
a.bg-success:hover, a.bg-success:active {
  background: #bafa7a !important;
}

a.bg-danger {
  background: #FB9393 !important;
  color: #FFF !important;
}
a.bg-danger:hover, a.bg-danger:active {
  background: #fa7a7a !important;
}

a.bg-warning {
  background: #FBC593 !important;
  color: #FFF !important;
}
a.bg-warning:hover, a.bg-warning:active {
  background: #fab87a !important;
}

a.bg-info {
  background: #ffffff !important;
  color: #FFF !important;
}
a.bg-info:hover, a.bg-info:active {
  background: #f2f2f2 !important;
}

a.bg-light {
  background: rgba(255, 255, 255, 0.5) !important;
}
a.bg-light:hover, a.bg-light:active {
  background: rgba(242, 242, 242, 0.5) !important;
}

a.bg-dark {
  background: #222 !important;
  color: #FFF !important;
}
a.bg-dark:hover, a.bg-dark:active {
  background: #151515 !important;
}

.text-primary,
a.text-primary {
  color: #2E2481 !important;
}

.text-secondary,
a.text-secondary {
  color: #53AAC6 !important;
}

.text-success,
a.text-success {
  color: #C7FB93 !important;
}

.text-danger,
a.text-danger {
  color: #FB9393 !important;
}

.text-warning,
a.text-warning {
  color: #FBC593 !important;
}

.text-info,
a.text-info {
  color: #ffffff !important;
}

.text-light,
a.text-light {
  color: #FFF !important;
}

.text-dark,
a.text-dark {
  color: #1c1b1b !important;
}

.border-primary {
  border-color: #2E2481 !important;
}

.border-secondary {
  border-color: #53AAC6 !important;
}

.border-success {
  border-color: #C7FB93 !important;
}

.border-danger {
  border-color: #FB9393 !important;
}

.border-warning {
  border-color: #FBC593 !important;
}

.border-info {
  border-color: #ffffff !important;
}

.border-light {
  border-color: #FFF !important;
}

.border-dark {
  border-color: #1c1b1b !important;
}

.alert {
  margin: 0;
  padding: 6px 16px;
  border: 0;
  font-size: 13px;
  border-radius: 24px;
}
.alert .btn-close {
  text-shadow: none !important;
  width: 40px;
  padding: 0;
  opacity: 1;
  line-height: 1em;
  height: 36px !important;
  outline: 0 !important;
  box-shadow: none !important;
  background: none;
}
.alert .btn-close:hover, .alert .btn-close:active, .alert .btn-close:focus {
  outline: 0 !important;
}
.alert .btn-close:hover {
  opacity: 0.7;
}
.alert .btn-close:before, .alert .btn-close:after {
  position: absolute;
  width: 16px;
  height: 2px;
  left: 12px;
  top: 16px;
  content: "";
  display: block;
  background: #FFF;
  border-radius: 20px;
}
.alert .btn-close:before {
  transform: rotate(45deg);
}
.alert .btn-close:after {
  transform: rotate(-45deg);
}
.alert .alert-title {
  margin: 4px 0;
  font-size: 15px;
  font-weight: 500;
}
.alert.alert-dismissible {
  padding-right: 56px;
}

.alert-primary {
  background: #2E2481;
  color: #fff;
  border: 1px solid #2E2481;
}
.alert-primary a {
  color: #fff !important;
  text-decoration: underline;
}
.alert-primary .alert-title {
  color: #FFF;
}
.alert-primary .close {
  color: #FFF;
}

.alert-outline-primary {
  background: transparent;
  color: #2E2481;
  border: 1px solid #2E2481;
}
.alert-outline-primary a {
  color: #2E2481 !important;
  text-decoration: underline !important;
}
.alert-outline-primary .alert-title {
  color: #2E2481;
}
.alert-outline-primary .btn-close {
  color: #2E2481;
  opacity: 1;
}
.alert-outline-primary .btn-close:before, .alert-outline-primary .btn-close:after {
  background: #2E2481;
}

.alert-secondary {
  background: #53AAC6;
  color: #fff;
  border: 1px solid #53AAC6;
}
.alert-secondary a {
  color: #fff !important;
  text-decoration: underline;
}
.alert-secondary .alert-title {
  color: #FFF;
}
.alert-secondary .close {
  color: #FFF;
}

.alert-outline-secondary {
  background: transparent;
  color: #53AAC6;
  border: 1px solid #53AAC6;
}
.alert-outline-secondary a {
  color: #53AAC6 !important;
  text-decoration: underline !important;
}
.alert-outline-secondary .alert-title {
  color: #53AAC6;
}
.alert-outline-secondary .btn-close {
  color: #53AAC6;
  opacity: 1;
}
.alert-outline-secondary .btn-close:before, .alert-outline-secondary .btn-close:after {
  background: #53AAC6;
}

.alert-success {
  background: #C7FB93;
  color: #fff;
  border: 1px solid #C7FB93;
}
.alert-success a {
  color: #fff !important;
  text-decoration: underline;
}
.alert-success .alert-title {
  color: #FFF;
}
.alert-success .close {
  color: #FFF;
}

.alert-outline-success {
  background: transparent;
  color: #C7FB93;
  border: 1px solid #C7FB93;
}
.alert-outline-success a {
  color: #C7FB93 !important;
  text-decoration: underline !important;
}
.alert-outline-success .alert-title {
  color: #C7FB93;
}
.alert-outline-success .btn-close {
  color: #C7FB93;
  opacity: 1;
}
.alert-outline-success .btn-close:before, .alert-outline-success .btn-close:after {
  background: #C7FB93;
}

.alert-danger {
  background: #FB9393;
  color: #fff;
  border: 1px solid #FB9393;
}
.alert-danger a {
  color: #fff !important;
  text-decoration: underline;
}
.alert-danger .alert-title {
  color: #FFF;
}
.alert-danger .close {
  color: #FFF;
}

.alert-outline-danger {
  background: transparent;
  color: #FB9393;
  border: 1px solid #FB9393;
}
.alert-outline-danger a {
  color: #FB9393 !important;
  text-decoration: underline !important;
}
.alert-outline-danger .alert-title {
  color: #FB9393;
}
.alert-outline-danger .btn-close {
  color: #FB9393;
  opacity: 1;
}
.alert-outline-danger .btn-close:before, .alert-outline-danger .btn-close:after {
  background: #FB9393;
}

.alert-warning {
  background: #FBC593;
  color: #fff;
  border: 1px solid #FBC593;
}
.alert-warning a {
  color: #fff !important;
  text-decoration: underline;
}
.alert-warning .alert-title {
  color: #FFF;
}
.alert-warning .close {
  color: #FFF;
}

.alert-outline-warning {
  background: transparent;
  color: #FBC593;
  border: 1px solid #FBC593;
}
.alert-outline-warning a {
  color: #FBC593 !important;
  text-decoration: underline !important;
}
.alert-outline-warning .alert-title {
  color: #FBC593;
}
.alert-outline-warning .btn-close {
  color: #FBC593;
  opacity: 1;
}
.alert-outline-warning .btn-close:before, .alert-outline-warning .btn-close:after {
  background: #FBC593;
}

.alert-info {
  background: #ffffff;
  color: #fff;
  border: 1px solid #ffffff;
}
.alert-info a {
  color: #fff !important;
  text-decoration: underline;
}
.alert-info .alert-title {
  color: #FFF;
}
.alert-info .close {
  color: #FFF;
}

.alert-outline-info {
  background: transparent;
  color: #ffffff;
  border: 1px solid #ffffff;
}
.alert-outline-info a {
  color: #ffffff !important;
  text-decoration: underline !important;
}
.alert-outline-info .alert-title {
  color: #ffffff;
}
.alert-outline-info .btn-close {
  color: #ffffff;
  opacity: 1;
}
.alert-outline-info .btn-close:before, .alert-outline-info .btn-close:after {
  background: #ffffff;
}

.alert-light {
  background: #FFF;
  color: #1c1b1b;
}

.alert-dark {
  background: #333;
  color: #FFF;
}
.alert-dark a {
  color: #FFF !important;
  text-decoration: underline !important;
}

.alert-outline-dark {
  background: transparent;
  color: #333;
  border: 1px solid #333;
}

.table {
  color: #4F5050;
  margin: 0;
  font-size: 13px;
  line-height: 1.4em;
}
.table tr {
  border-color: #E1E1E1;
}
.table thead th {
  border-top: 0;
  border-bottom: 0;
  color: #1c1b1b;
  font-weight: 500;
}
.table td,
.table th {
  border-top: 1px solid #E1E1E1;
  padding: 12px;
}

.table-striped > tbody > tr:nth-of-type(odd) {
  background: rgba(225, 225, 225, 0.1);
  color: #4F5050;
}

.table-bordered {
  border-radius: 0px;
}
.table-bordered td,
.table-bordered th {
  border-color: #E1E1E1;
}

.table.bg-primary,
.table.bg-secondary,
.table.bg-success,
.table.bg-danger,
.table.bg-warning,
.table.bg-info {
  color: rgba(255, 255, 255, 0.7);
}
.table.bg-primary tr,
.table.bg-primary td,
.table.bg-primary th,
.table.bg-secondary tr,
.table.bg-secondary td,
.table.bg-secondary th,
.table.bg-success tr,
.table.bg-success td,
.table.bg-success th,
.table.bg-danger tr,
.table.bg-danger td,
.table.bg-danger th,
.table.bg-warning tr,
.table.bg-warning td,
.table.bg-warning th,
.table.bg-info tr,
.table.bg-info td,
.table.bg-info th {
  border-bottom-color: rgba(255, 255, 255, 0.2);
}
.table.bg-primary td,
.table.bg-primary th,
.table.bg-secondary td,
.table.bg-secondary th,
.table.bg-success td,
.table.bg-success th,
.table.bg-danger td,
.table.bg-danger th,
.table.bg-warning td,
.table.bg-warning th,
.table.bg-info td,
.table.bg-info th {
  border-top-color: rgba(255, 255, 255, 0.2);
}
.table.bg-primary thead tr th,
.table.bg-secondary thead tr th,
.table.bg-success thead tr th,
.table.bg-danger thead tr th,
.table.bg-warning thead tr th,
.table.bg-info thead tr th {
  color: #fff;
  font-weight: 500;
}

textarea,
.form-control {
  background-clip: padding-box;
  background-image: linear-gradient(transparent, transparent);
  -webkit-appearance: none;
  -moz-appearance: none;
  appearance: none;
}

.form-group {
  width: 100%;
}
.form-group .form-label {
  font-size: 11px;
  font-weight: 500;
  color: #1c1b1b;
  display: block;
  line-height: 1.2em;
  text-align: left;
}
.form-group textarea {
  resize: none;
}
.form-group .input-info {
  font-size: 11px;
  color: #939393;
}
.form-group .clear-input {
  display: flex;
  align-items: center;
  justify-content: center;
  color: #4F5050;
  height: 38px;
  font-size: 22px;
  position: absolute;
  z-index: 2;
  right: -10px;
  bottom: 0;
  width: 32px;
  opacity: 0.5;
  display: none;
}
.form-group .clear-input i.bi {
  font-size: 20px;
}
.form-group .clear-input:hover, .form-group .clear-input:active {
  opacity: 0.8;
}
.form-group .input-wrapper {
  position: relative;
}
.form-group .input-wrapper.not-empty .clear-input {
  display: flex;
}
.form-group .input-wrapper.active .form-label {
  color: #2E2481 !important;
}

.form-group.basic {
  padding: 8px 0;
  margin: 0;
}
.form-group.basic .form-label {
  margin-bottom: 0;
}
.form-group.basic .form-control,
.form-group.basic .custom-select {
  background: transparent;
  border: none;
  border-bottom: 1px solid #E1E1E1;
  padding: 0 30px 0 0;
  border-radius: 0;
  height: 40px;
  color: #1c1b1b;
  font-size: 15px;
}
.form-group.basic .form-control:focus,
.form-group.basic .custom-select:focus {
  border-bottom-color: #2E2481;
  box-shadow: inset 0 -1px 0 0 #2E2481;
}
.form-group.basic textarea.form-control {
  height: auto;
  padding: 7px 40px 7px 0;
}

.form-group.basic.animated .form-label {
  margin-top: 20px;
  opacity: 0;
  top: -3px;
  transition: 0.2s all;
  position: absolute;
}
.form-group.basic.animated .input-wrapper {
  padding-top: 5px;
}
.form-group.basic.animated .input-wrapper.not-empty .form-label {
  margin-top: 0;
  opacity: 1;
}

.form-group.boxed {
  margin: 0;
  padding: 8px 0;
}
.form-group.boxed .form-control {
  background: #fff;
  box-shadow: none;
  height: 42px;
  border-radius: 24px;
  padding: 0 40px 0 16px;
  border-color: #E1E1E1;
}
.form-group.boxed .form-control:focus {
  border-color: #2E2481;
}
.form-group.boxed textarea.form-control {
  height: auto;
  padding: 7px 40px 7px 16px;
}
.form-group.boxed .clear-input {
  right: 0;
  height: 42px;
  width: 40px;
}
.form-group.boxed .form-label {
  margin-bottom: 8px;
}

.input-group .input-group-text {
  background: transparent;
  border: 0;
  border-bottom: 1px solid #E1E1E1;
  border-radius: 0;
  font-size: 20px;
  font-weight: 400;
  color: #1c1b1b;
  height: 40px;
  width: auto;
  padding: 0 10px 0 0;
}

.custom-file-upload {
  cursor: pointer;
  position: relative;
  display: flex;
  width: 100%;
  height: 220px;
}
.custom-file-upload input[type=file] {
  overflow: hidden;
  opacity: 0;
  position: absolute;
  top: 0;
  left: 0;
  width: 0;
  height: 0;
}
.custom-file-upload label {
  cursor: pointer;
  z-index: 1;
  position: absolute;
  left: 0;
  top: 0;
  bottom: 0;
  right: 0;
  overflow: hidden;
  background-color: rgba(225, 225, 225, 0.2);
  background-size: 45px 58px;
  border: 1px solid #E1E1E1;
  border-radius: 24px;
  margin: 0;
}
.custom-file-upload label span {
  display: block;
  font-size: 15px;
  color: #939393;
  height: auto;
  position: absolute;
  top: 50%;
  left: 0;
  right: 0;
  font-weight: 500;
  transform: translate(0%, -50%);
  align-items: center;
  justify-content: center;
  padding: 10px 16px;
  width: 100%;
  text-align: center;
  border-radius: 0;
}
.custom-file-upload label span i.bi,
.custom-file-upload label span i.icon,
.custom-file-upload label span ion-icon {
  --ionicon-stroke-width: 32px;
  font-size: 48px;
  color: #939393;
}
.custom-file-upload label span strong {
  display: block;
  font-weight: 500;
}
.custom-file-upload label span i {
  font-style: normal;
  display: block;
}
.custom-file-upload label.file-uploaded {
  background-size: cover;
  background-position: center;
}
.custom-file-upload label.file-uploaded:before {
  content: "";
  width: 38px;
  height: 38px;
  background: #C7FB93;
  border-radius: 100%;
  display: flex;
  background-image: url("data:image/svg+xml,%0A%3Csvg width='23px' height='20px' viewBox='0 0 23 20' version='1.1' xmlns='http://www.w3.org/2000/svg' xmlns:xlink='http://www.w3.org/1999/xlink'%3E%3Cg id='Page-1' stroke='none' stroke-width='1' fill='none' fill-rule='evenodd' stroke-linecap='round' stroke-linejoin='round'%3E%3Cpolyline id='Path' stroke='%23FFFFFF' stroke-width='2.4' points='21.2 2 7.76 18 2 12'%3E%3C/polyline%3E%3C/g%3E%3C/svg%3E");
  background-repeat: no-repeat;
  background-position: center center;
  position: absolute;
  left: 50%;
  top: calc(50% - 22px);
  box-shadow: 0px 4px 4px rgba(0, 0, 0, 0.25);
  transform: translate(-50%, -50%);
}
.custom-file-upload label.file-uploaded label {
  border-color: transparent;
}
.custom-file-upload label.file-uploaded span {
  bottom: 0;
  left: 0;
  top: auto;
  transform: translate(0, 0);
  font-size: 11px;
  color: #4F5050;
  background-color: #E1E1E1;
}

.verify-input {
  height: 72px !important;
  font-size: 32px;
  font-weight: 700;
  color: #1c1b1b;
  letter-spacing: 5px;
  padding: 0 0 0 5px !important;
  max-width: 190px;
  margin: auto;
  text-align: center !important;
}

.form-group.boxed .form-control.form-select,
.form-group.basic .form-control.form-select {
  background-image: url("data:image/svg+xml,%0A%3Csvg width='13px' height='8px' viewBox='0 0 13 8' version='1.1' xmlns='http://www.w3.org/2000/svg' xmlns:xlink='http://www.w3.org/1999/xlink'%3E%3Cg id='Page-1' stroke='none' stroke-width='1' fill='none' fill-rule='evenodd' stroke-linecap='round' stroke-linejoin='round'%3E%3Cpolyline id='Path' stroke='%23A9ABAD' stroke-width='2' points='1.59326172 1.79663086 6.59326172 6.79663086 11.5932617 1.79663086'%3E%3C/polyline%3E%3C/g%3E%3C/svg%3E") !important;
  background-repeat: no-repeat !important;
  background-position: right center !important;
}

.form-group.boxed .form-control.form-select {
  background-position: right 12px center !important;
}

.nav-tabs {
  width: 100%;
}

.nav-tabs.capsuled {
  border: 0;
  background: rgba(225, 225, 225, 0.4);
  border-radius: 24px;
  display: flex;
}
.nav-tabs.capsuled .nav-item {
  flex: 1;
  width: 100%;
  text-align: center;
  display: flex;
  justify-content: center;
  align-items: center;
  margin: 0;
  padding: 0;
}
.nav-tabs.capsuled .nav-item .nav-link {
  color: #4F5050;
  font-weight: 500;
  font-size: 13px;
  border: 0 !important;
  line-height: 1.2em;
  width: 100%;
  border-radius: 24px;
  padding: 6px 10px;
  height: 30px;
  display: flex;
  align-items: center;
  justify-content: center;
  margin: 4px !important;
}
.nav-tabs.capsuled .nav-item .nav-link i.bi,
.nav-tabs.capsuled .nav-item .nav-link i.icon,
.nav-tabs.capsuled .nav-item .nav-link ion-icon {
  margin-right: 8px;
  margin-left: 8px;
  line-height: 1em;
  font-size: 18px;
}
.nav-tabs.capsuled .nav-item .nav-link.active {
  color: #1c1b1b;
  box-shadow: 0px 4px 4px rgba(0, 0, 0, 0.25);
}

.nav-tabs.lined {
  border: 0;
  background: transparent;
  border-radius: 0;
  display: flex;
}
.nav-tabs.lined .nav-item {
  flex: 1;
  width: 100%;
  text-align: center;
  display: flex;
  justify-content: center;
  align-items: center;
  margin: 0;
  padding: 0;
}
.nav-tabs.lined .nav-item .nav-link {
  color: #4F5050;
  font-weight: 500;
  font-size: 13px;
  border: 0 !important;
  border-bottom: 2px solid transparent !important;
  line-height: 1.2em;
  width: 100%;
  border-radius: 0;
  padding: 6px 10px;
  height: 56px;
  display: flex;
  align-items: center;
  justify-content: center;
  margin: 0 !important;
}
.nav-tabs.lined .nav-item .nav-link i.bi,
.nav-tabs.lined .nav-item .nav-link i.icon,
.nav-tabs.lined .nav-item .nav-link ion-icon {
  margin-right: 8px;
  margin-left: 8px;
  line-height: 1em;
  font-size: 18px;
}
.nav-tabs.lined .nav-item .nav-link.active {
  color: #2E2481;
  background: transparent;
  border-bottom-color: #2E2481 !important;
}

.nav-tabs.iconed i.bi,
.nav-tabs.iconed i.icon,
.nav-tabs.iconed ion-icon {
  font-size: 24px !important;
}

.form-check {
  padding: 0;
  margin: 0;
  min-height: auto;
  height: auto;
}
.form-check .form-check-input {
  display: none;
}
.form-check .form-check-label {
  cursor: pointer;
  position: relative;
  min-height: 20px;
  padding: 0px 0 0 32px;
  line-height: 1.7em;
  color: #1c1b1b;
}
.form-check .form-check-label:after {
  position: absolute;
  left: 0;
  top: 0;
  content: "";
  display: block;
  width: 22px;
  height: 22px;
  background: transparent;
  border-radius: 100px;
  border: 1px solid #E1E1E1;
}
.form-check .form-check-label:before {
  content: "";
  display: block;
  width: 22px;
  height: 22px;
  position: absolute;
  left: 0;
  top: 0;
  z-index: 3;
  opacity: 0;
  background-image: url("data:image/svg+xml,%3csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 20 20'%3e%3cpath fill='none' stroke='%23fff' stroke-linecap='round' stroke-linejoin='round' stroke-width='2' d='M6 10l3 3l6-6'/%3e%3c/svg%3e");
}

.form-check-input[type=radio] ~ .form-check-label:before {
  background-image: url("data:image/svg+xml,%0A%3Csvg width='8px' height='8px' viewBox='0 0 8 8' version='1.1' xmlns='http://www.w3.org/2000/svg' xmlns:xlink='http://www.w3.org/1999/xlink'%3E%3Cg id='Page-1' stroke='none' stroke-width='1' fill='none' fill-rule='evenodd'%3E%3Ccircle id='Oval' fill='%23FFFFFF' cx='4' cy='4' r='4'%3E%3C/circle%3E%3C/g%3E%3C/svg%3E");
  background-repeat: no-repeat;
  background-position: center center;
}

.form-check-input:checked ~ .form-check-label:after {
  background-color: #2E2481;
  border-color: #2E2481 !important;
}
.form-check-input:checked ~ .form-check-label:before {
  opacity: 1;
}

.form-check-inline {
  margin-right: 0;
}
.form-check-inline .form-check-label {
  margin-bottom: -3px;
  padding-left: 24px;
}

.input-list .form-check:after {
  content: "";
  height: 1px;
  background: #E1E1E1;
  display: block;
  margin-left: 54px;
}
.input-list .form-check .form-check-label {
  min-height: 50px;
  display: flex;
  align-items: center;
  justify-content: space-between;
  transition: 0.1s all;
  padding: 6px 16px 6px 54px;
}
.input-list .form-check .form-check-label:before, .input-list .form-check .form-check-label:after {
  left: 16px;
  top: 14px;
}
.input-list .form-check .form-check-label:active {
  background: rgba(225, 225, 225, 0.3);
}
.input-list .form-check:last-child:after {
  height: 0;
}

.form-switch {
  height: 30px;
}
.form-switch .form-check-label {
  width: 56px;
  height: 30px;
  padding: 0;
  margin: 0;
}
.form-switch .form-check-label:after {
  height: 30px;
  width: 56px;
  background: #E1E1E1;
  border: 1px solid #d4d4d4;
  transition: 0.1s linear;
}
.form-switch .form-check-label:before {
  opacity: 1;
  border-radius: 100px;
  width: 24px;
  height: 24px;
  top: 3px;
  left: 4px;
  background: #ffffff;
  box-shadow: 0 3px 6px 0 rgba(0, 0, 0, 0.1), 0 1px 3px 0 rgba(0, 0, 0, 0.08);
  transition: 0.15s ease-in-out;
}
.form-switch .form-check-input:checked ~ .form-check-label:before {
  left: 28px;
}

.message-divider {
  font-size: 12px;
  text-align: center;
  padding: 5px 0;
  color: #939393;
}

.message-item {
  display: flex;
  align-items: flex-end;
  justify-content: flex-start;
  padding: 2px 16px;
  margin-right: 60px;
}
.message-item .bubble {
  padding: 10px 16px;
  background: #FFF;
  border-radius: 16px 16px 16px 0;
  box-shadow: 0px 4px 4px rgba(0, 0, 0, 0.25);
  color: #1c1b1b;
  display: inline-block;
  margin-top: 4px;
  line-height: 1.4em;
}
.message-item .bubble .imaged {
  margin: 0px -6px;
}
.message-item .title {
  font-size: 12px;
  font-weight: 500;
  color: #4F5050;
  line-height: 1.2em;
  padding: 0 0 0 10px;
}
.message-item .footer {
  font-size: 12px;
  padding: 0 10px;
  text-align: right;
  line-height: 1em;
  margin-top: 5px;
  color: #1c1b1b;
  opacity: 0.4;
  height: 14px;
}
.message-item .avatar {
  margin-right: 10px;
  width: 32px;
  height: auto;
  border-radius: 100%;
  margin-bottom: 18px;
}
.message-item.user {
  justify-content: flex-end;
  margin-right: 0;
  margin-left: 60px;
}
.message-item.user .bubble {
  background: #2E2481;
  color: #FFF;
  border-radius: 16px 16px 0 16px;
}

.chatFooter {
  min-height: 56px;
  background: #FFF;
  border-top: 1px solid #E1E1E1;
  position: fixed;
  left: 0;
  right: 0;
  bottom: 0;
  width: 100%;
  display: flex;
  align-items: center;
  justify-content: space-between;
  padding-left: 14px;
  padding-right: 14px;
  padding-bottom: env(safe-area-inset-bottom);
}
.chatFooter .form-group {
  width: calc(100% - 100px);
}
.chatFooter .form-group .form-control {
  font-size: 13px;
  border-radius: 300px;
  height: 40px;
}
.chatFooter .form-group .clear-input {
  height: 40px;
}
.chatFooter form {
  width: 100%;
  display: flex;
  align-items: center;
  justify-content: space-between;
}

.progress {
  height: 14px;
  border-radius: 24px;
}

.progress-bar {
  background: #2E2481;
  height: 14px;
  line-height: 1em;
  display: flex;
  align-items: center;
  justify-content: center;
  font-size: 10px;
  font-weight: 500;
  letter-spacing: 0;
}

.circle-progress2 {
  width: 100%;
  height: 100%;
  position: relative;
  display: flex;
  align-items: center;
  justify-content: center;
}
.circle-progress2 .inner {
  position: absolute;
  text-align: center;
  font-size: 11px !important;
  line-height: 1.2em;
}
.circle-progress2 .inner h4 {
  margin: 0;
  font-weight: 700;
  font-size: 17px;
}
.circle-progress2 > svg {
  height: 100%;
  display: block;
}

.circle-progress-container {
  width: 100%;
  position: relative;
  display: flex;
  align-items: center;
  justify-content: center;
  padding: 0;
}
.circle-progress-container .inner {
  position: absolute;
  left: 50%;
  top: 50%;
  transform: translate(-50%, -50%);
  text-align: center;
  align-items: center;
  justify-content: center;
  font-size: 11px !important;
  line-height: 1.2em;
}
.circle-progress-container .inner h4 {
  margin: 0;
  font-weight: 700;
  font-size: 17px;
}
.circle-progress-container svg {
  height: 100% !important;
  width: 100% !important;
  display: block;
}

.chip {
  background: #E1E1E1;
  font-size: 13px;
  color: #1c1b1b;
  line-height: 1em;
  height: 26px;
  display: inline-flex;
  align-items: center;
  justify-content: space-between;
  padding: 0;
  border-radius: 100px;
}
.chip .chip-label {
  padding: 0 12px;
}
.chip.chip-outline {
  background: transparent;
  box-shadow: inset 0 0 0 1px #E1E1E1;
}
.chip.chip-media {
  position: relative;
  padding-left: 20px;
}
.chip.chip-media img {
  width: 26px;
  height: 26px;
  border-radius: 100px;
  position: absolute;
  left: 0;
  top: 0;
}
.chip .chip-icon {
  position: absolute;
  left: 0;
  top: 0;
  width: 26px;
  height: 26px;
  margin: 0;
  display: flex;
  align-items: center;
  justify-content: center;
  border-radius: 100px;
  background: #4F5050;
  color: #fff;
  font-size: 14px;
}
.chip .chip-delete {
  width: 26px;
  margin-left: -10px;
  height: 26px;
  display: inline-flex;
  color: #1c1b1b;
  opacity: 0.7;
  align-items: center;
  justify-content: center;
  font-size: 16px;
  border-radius: 100px;
}
.chip .chip-delete:hover, .chip .chip-delete:active {
  opacity: 1;
}

.chip-primary {
  background: #2E2481 !important;
  color: #fff !important;
}
.chip-primary .chip-delete {
  color: #fff !important;
}
.chip-primary.chip-outline {
  background: transparent !important;
  color: #2E2481 !important;
  box-shadow: inset 0 0 0 1px #2E2481 !important;
}

.chip-danger {
  background: #FB9393 !important;
  color: #fff !important;
}
.chip-danger .chip-delete {
  color: #fff !important;
}
.chip-danger.chip-outline {
  background: transparent !important;
  color: #FB9393 !important;
  box-shadow: inset 0 0 0 1px #FB9393 !important;
}

.chip-success {
  background: #C7FB93 !important;
  color: #fff !important;
}
.chip-success .chip-delete {
  color: #fff !important;
}
.chip-success.chip-outline {
  background: transparent !important;
  color: #C7FB93 !important;
  box-shadow: inset 0 0 0 1px #C7FB93 !important;
}

.chip-warning {
  background: #FBC593 !important;
  color: #fff !important;
}
.chip-warning .chip-delete {
  color: #fff !important;
}
.chip-warning.chip-outline {
  background: transparent !important;
  color: #FBC593 !important;
  box-shadow: inset 0 0 0 1px #FBC593 !important;
}

.chip-info {
  background: #ffffff !important;
  color: #fff !important;
}
.chip-info .chip-delete {
  color: #fff !important;
}
.chip-info.chip-outline {
  background: transparent !important;
  color: #ffffff !important;
  box-shadow: inset 0 0 0 1px #ffffff !important;
}

.chip-light {
  background: #fff !important;
  color: #000 !important;
}
.chip-light .chip-delete {
  color: #000 !important;
}
.chip-light.chip-outline {
  background: transparent !important;
  color: #fff !important;
  box-shadow: inset 0 0 0 1px #fff !important;
}

.chip-dark {
  background: #000 !important;
  color: #fff !important;
}
.chip-dark .chip-delete {
  color: #fff !important;
}
.chip-dark.chip-outline {
  background: transparent !important;
  color: #000 !important;
  box-shadow: inset 0 0 0 1px #000 !important;
}

.search-form {
  display: block;
  width: 100%;
}

.searchbox {
  width: 100%;
  margin: 0;
  position: relative;
  display: flex;
  align-items: center;
  justify-content: space-between;
}
.searchbox .form-control {
  height: 36px;
  border-radius: 24px;
  border: 1px solid #E1E1E1 !important;
  padding: 0 16px 0 36px;
  font-size: 15px;
  box-shadow: none !important;
  color: #1c1b1b;
}
.searchbox .form-control:focus {
  border-color: #c8c8c8 !important;
}
.searchbox .form-control:focus ~ .input-icon {
  color: #1c1b1b;
}
.searchbox i.bi,
.searchbox i.icon,
.searchbox ion-icon {
  font-size: 26px;
  line-height: 1em;
  margin: 0;
}
.searchbox .close {
  opacity: 1;
  color: #939393;
  width: 46px;
  height: 56px;
  display: flex;
  align-items: center;
  justify-content: center;
  position: absolute;
  right: 8px;
  top: 0;
}
.searchbox .input-icon {
  font-size: 26px;
  position: absolute;
  left: 0px;
  width: 36px;
  height: 36px;
  display: flex;
  align-items: center;
  justify-content: center;
  color: #939393;
  top: 0;
}

#search {
  display: block;
  padding: 0;
  background: #fff;
  border-bottom: 1px solid #FFF;
  position: fixed;
  box-shadow: 0px 4px 4px rgba(0, 0, 0, 0.25);
  left: 0;
  top: -100px;
  right: 0;
  width: 100%;
  z-index: 1001;
  transition: 0.3s all ease-in-out;
}
#search.show {
  top: env(safe-area-inset-top);
  transition: 0.22s all ease-in-out;
}
#search .searchbox .form-control {
  box-shadow: none !important;
  border: 0 !important;
  border-radius: 0;
  height: 56px;
  padding: 0 56px 0 56px;
  background: transparent;
  font-size: 17px;
  color: #1c1b1b;
  width: 100%;
}
#search .searchbox .form-control:focus {
  border-color: #bbbbbb;
}
#search .searchbox .form-control:focus ~ .input-icon {
  color: #1c1b1b;
}
#search .searchbox .input-icon {
  font-size: 26px;
  position: absolute;
  left: 8px;
  width: 46px;
  height: 56px;
  display: flex;
  align-items: center;
  justify-content: center;
  color: #939393;
  top: 0;
}

.search-result li > .item,
.search-result li > a {
  padding-top: 20px;
  padding-bottom: 20px;
}

.splide {
  margin-bottom: -20px !important;
}
.splide:active {
  cursor: grab;
}
.splide .splide__list {
  padding-bottom: 20px !important;
}

.carousel-single .splide__slide,
.carousel-small .splide__slide {
  margin-left: -16px !important;
  padding-right: 16px !important;
}

.carousel-multiple .splide__slide {
  margin-left: -8px !important;
  padding-right: 8px !important;
}

.carousel-slider {
  text-align: center;
}
.carousel-slider .splide__list {
  padding-bottom: 100px !important;
}
.carousel-slider .imaged.w-100 {
  max-width: 400px;
  margin-left: auto;
  margin-right: auto;
}
.carousel-slider .splide__pagination {
  position: fixed;
  width: 100%;
  bottom: 120px;
}
.carousel-slider .splide__pagination button {
  background: #E1E1E1;
  margin: 0 5px !important;
}
.carousel-slider .splide__pagination button.is-active {
  background: #939393;
  transform: scale(1);
}

.carousel-button-footer {
  min-height: 84px;
  padding-left: 8px;
  padding-right: 8px;
  padding-bottom: env(safe-area-inset-bottom);
  width: 100%;
  position: fixed;
  display: flex;
  align-items: center;
  justify-content: center;
  z-index: 990;
  left: 0;
  bottom: 0;
  right: 0;
}
.carousel-button-footer > div {
  width: 100%;
}

.login-form {
  max-width: 500px;
  margin: auto;
  text-align: center;
}
.login-form .form-image {
  width: 100%;
  max-width: 200px;
  height: auto;
}

.form-button-group {
  position: fixed;
  bottom: 0;
  left: 0;
  right: 0;
  width: 100%;
  padding-left: 16px;
  padding-right: 16px;
  background: #FFF;
  min-height: 84px;
  display: flex;
  align-items: center;
  justify-content: center;
  padding-bottom: env(safe-area-inset-bottom);
}

.form-links {
  display: flex;
  align-items: flex-start;
  justify-content: space-between;
  font-size: 14px;
}

.timeline {
  position: relative;
  padding: 24px 0;
}
.timeline:before {
  content: "";
  display: block;
  position: absolute;
  width: 2px;
  left: 0;
  bottom: 0;
  top: 0;
  background: #E1E1E1;
  z-index: 1;
}
.timeline .item {
  position: relative;
  margin-bottom: 40px;
}
.timeline .item:last-child {
  margin-bottom: 0;
}
.timeline .content {
  padding-left: 20px;
}
.timeline .content .title {
  margin-bottom: 5px;
  line-height: 1.3em;
}
.timeline .content .text {
  font-size: 13px;
  line-height: 1.4em;
  padding-right: 30px;
}
.timeline .dot {
  width: 12px;
  height: 12px;
  border-radius: 100%;
  position: absolute;
  background: #939393;
  left: -5px;
  top: 50%;
  margin-top: -6px;
  z-index: 10;
  box-shadow: 0 0 0 3px #FFF;
}

.timeline.timed {
  padding-left: 80px;
}
.timeline.timed:before {
  left: 80px;
}
.timeline.timed .time {
  font-size: 11px;
  position: absolute;
  left: -80px;
  line-height: 1.5em;
  width: 70px;
  text-align: right;
  top: 50%;
  transform: translate(0, -50%);
  z-index: 20;
}

.form-wizard-section {
  display: flex;
  align-items: flex-start;
  justify-content: center;
  width: 100%;
  padding: 4px 0 0 0;
  position: relative;
}
.form-wizard-section:before {
  content: "";
  height: 1px;
  background: #E1E1E1;
  width: 100%;
  position: absolute;
  top: 16px;
}
.form-wizard-section .button-item {
  flex: 1;
  text-align: center;
  padding: 0 6px;
  position: relative;
}
.form-wizard-section .button-item strong {
  background: #E1E1E1;
  width: 22px;
  height: 22px;
  border-radius: 100%;
  color: #939393;
  display: inline-flex;
  align-items: center;
  justify-content: center;
  font-size: 14px;
  line-height: 1em;
  position: relative;
  z-index: 2;
}
.form-wizard-section .button-item strong i.bi,
.form-wizard-section .button-item strong i.icon,
.form-wizard-section .button-item strong ion-icon {
  font-size: 16px;
}
.form-wizard-section .button-item p {
  font-size: 10px;
  line-height: 1em;
  color: #939393;
  margin: 4px 0 0 0;
}
.form-wizard-section .button-item.active strong {
  background: #2E2481;
  color: #fff;
}
.form-wizard-section .button-item.active p {
  color: #1c1b1b;
}

.extraHeader.bg-primary .form-wizard-section:before, .extraHeader.bg-secondary .form-wizard-section:before, .extraHeader.bg-success .form-wizard-section:before, .extraHeader.bg-danger .form-wizard-section:before, .extraHeader.bg-warning .form-wizard-section:before, .extraHeader.bg-dark .form-wizard-section:before {
  background: transparent;
}
.extraHeader.bg-primary .form-wizard-section .button-item strong, .extraHeader.bg-secondary .form-wizard-section .button-item strong, .extraHeader.bg-success .form-wizard-section .button-item strong, .extraHeader.bg-danger .form-wizard-section .button-item strong, .extraHeader.bg-warning .form-wizard-section .button-item strong, .extraHeader.bg-dark .form-wizard-section .button-item strong {
  background: rgba(255, 255, 255, 0.4);
  color: #FFF;
}
.extraHeader.bg-primary .form-wizard-section .button-item p, .extraHeader.bg-secondary .form-wizard-section .button-item p, .extraHeader.bg-success .form-wizard-section .button-item p, .extraHeader.bg-danger .form-wizard-section .button-item p, .extraHeader.bg-warning .form-wizard-section .button-item p, .extraHeader.bg-dark .form-wizard-section .button-item p {
  color: rgba(255, 255, 255, 0.7);
}
.extraHeader.bg-primary .form-wizard-section .button-item.active strong, .extraHeader.bg-secondary .form-wizard-section .button-item.active strong, .extraHeader.bg-success .form-wizard-section .button-item.active strong, .extraHeader.bg-danger .form-wizard-section .button-item.active strong, .extraHeader.bg-warning .form-wizard-section .button-item.active strong, .extraHeader.bg-dark .form-wizard-section .button-item.active strong {
  background: rgba(0, 0, 0, 0.5);
  color: #fff;
}
.extraHeader.bg-primary .form-wizard-section .button-item.active p, .extraHeader.bg-secondary .form-wizard-section .button-item.active p, .extraHeader.bg-success .form-wizard-section .button-item.active p, .extraHeader.bg-danger .form-wizard-section .button-item.active p, .extraHeader.bg-warning .form-wizard-section .button-item.active p, .extraHeader.bg-dark .form-wizard-section .button-item.active p {
  color: #FFF;
}

.adbox {
  text-align: center;
}
.adbox.fixed {
  position: fixed;
  bottom: 56px;
  left: 50%;
  margin-left: -150px;
  width: 300px;
  z-index: 100;
  padding-bottom: env(safe-area-inset-bottom);
}
.adbox.fixed .closebutton {
  width: 24px;
  height: 24px;
  font-size: 22px;
  background: rgba(0, 0, 0, 0.4);
  color: rgba(255, 255, 255, 0.5);
  display: flex;
  align-items: center;
  justify-content: center;
  position: absolute;
  right: 0;
  top: 0;
}
.adbox.hide.fixed {
  bottom: -100%;
}

.adbox-300-50 img {
  width: 300px;
  height: 50px;
}

.adbox-300-250 img {
  width: 300px;
  height: 250px;
}

.windowsphone-detection,
.ios-detection,
.android-detection,
.non-mobile-detection {
  display: none;
}
.windowsphone-detection.is-active,
.ios-detection.is-active,
.android-detection.is-active,
.non-mobile-detection.is-active {
  display: block;
}

.fab-button .fab {
  box-shadow: 0 4px 5px 0 rgba(0, 0, 0, 0.14), 0 1px 10px 0 rgba(0, 0, 0, 0.12), 0 2px 4px -1px rgba(0, 0, 0, 0.2);
  width: 56px;
  height: 56px;
  display: flex;
  align-items: center;
  justify-content: center;
  background: #2E2481;
  border-radius: 100%;
  color: #fff !important;
}
.fab-button .fab > i.bi,
.fab-button .fab > i.icon,
.fab-button .fab > ion-icon {
  font-size: 26px;
  transition: 0.2s all;
  --ionicon-stroke-width: 42px;
}
.fab-button .fab:hover, .fab-button .fab:active {
  background: #2E2481;
}
.fab-button.text .fab {
  width: auto;
  border-radius: 300px;
  font-size: 17px;
  padding: 0px 24px;
}
.fab-button.text .fab > i.bi,
.fab-button.text .fab > i.icon,
.fab-button.text .fab > ion-icon {
  margin-right: 6px;
}
.fab-button.animate .fab.show ion-icon[name=add],
.fab-button.animate .fab.show ion-icon[name=add-sharp],
.fab-button.animate .fab.show ion-icon[name=add-outline] {
  transform: rotate(45deg) !important;
}
.fab-button.dropdown.show .fab {
  background: #271e6d;
}
.fab-button .dropdown-menu {
  margin: 0;
  background: transparent;
  border: 0;
  box-shadow: none;
  padding: 0px 7px;
  width: 56px;
  min-width: 56px;
  max-width: 56px;
  text-align: center;
}
.fab-button .dropdown-menu .dropdown-item {
  padding: 0;
  background: #2E2481;
  width: 42px;
  height: 42px;
  display: flex !important;
  align-items: center;
  justify-content: center;
  color: #fff;
  margin: 14px 0;
  border-radius: 100%;
  box-shadow: 0px 4px 4px rgba(0, 0, 0, 0.25);
  position: relative;
}
.fab-button .dropdown-menu .dropdown-item:hover, .fab-button .dropdown-menu .dropdown-item:active {
  background: #2E2481;
}
.fab-button .dropdown-menu .dropdown-item i.bi,
.fab-button .dropdown-menu .dropdown-item i.icon,
.fab-button .dropdown-menu .dropdown-item ion-icon {
  --ionicon-stroke-width: 32px;
  line-height: 1em;
  margin-right: 0;
  color: #fff !important;
  width: 24px !important;
  height: 24px !important;
  display: flex !important;
  justify-content: center;
  align-items: center;
  line-height: 1em;
  display: inline-flex;
}
.fab-button .dropdown-menu .dropdown-item p {
  background: #FFF;
  position: absolute;
  left: 58px;
  top: 7px;
  color: #1c1b1b;
  font-size: 13px;
  padding: 4px 12px;
  line-height: 1.5em;
  border-radius: 24px;
  box-shadow: 0px 4px 4px rgba(0, 0, 0, 0.25);
}
.fab-button.bottom-right {
  position: fixed;
  bottom: 16px;
  right: 16px;
  z-index: 100;
  margin-bottom: env(safe-area-inset-bottom);
}
.fab-button.bottom-left {
  position: fixed;
  bottom: 16px;
  left: 16px;
  z-index: 100;
  margin-bottom: env(safe-area-inset-bottom);
}
.fab-button.bottom-center {
  position: fixed;
  bottom: 16px;
  left: 50%;
  transform: translate(-50%, 0%);
  margin-bottom: env(safe-area-inset-bottom);
}
.fab-button.top-center {
  position: fixed;
  top: 72px;
  left: 50%;
  transform: translate(-50%, 0%);
  margin-top: env(safe-area-inset-top);
}
.fab-button.top-left {
  position: fixed;
  top: 72px;
  left: 16px;
  z-index: 100;
  margin-top: env(safe-area-inset-top);
}
.fab-button.top-right {
  position: fixed;
  top: 72px;
  right: 16px;
  z-index: 100;
  margin-top: env(safe-area-inset-top);
}
.fab-button.top-right .dropdown-menu .dropdown-item p, .fab-button.bottom-right .dropdown-menu .dropdown-item p {
  left: auto;
  right: 58px;
}

.notification-box {
  position: fixed;
  left: 0;
  top: -100%;
  right: 0;
  width: 100%;
  z-index: 9999;
  transition: 0.3s all;
  margin-top: env(safe-area-inset-top);
}
.notification-box.show {
  top: 0;
}

.notification-dialog.android-style {
  background: #ffffff;
  box-shadow: 0 1px 1px 0 rgba(0, 0, 0, 0.14), 0 2px 1px -1px rgba(0, 0, 0, 0.12), 0 1px 3px 0 rgba(0, 0, 0, 0.2);
  padding: 16px 16px;
}
.notification-dialog.android-style .notification-header {
  display: flex;
  align-items: center;
  justify-content: space-between;
}
.notification-dialog.android-style .notification-header .in {
  display: flex;
  align-items: center;
}
.notification-dialog.android-style .notification-header .in .imaged {
  margin-right: 8px;
}
.notification-dialog.android-style .notification-header .in strong {
  font-size: 13px;
  font-weight: 400;
  color: #1c1b1b;
}
.notification-dialog.android-style .notification-header .in span {
  display: inline-flex;
  align-items: center;
  margin-left: 6px;
  font-size: 11px;
}
.notification-dialog.android-style .notification-header .in span:before {
  display: inline-flex;
  align-items: center;
  margin-right: 6px;
  content: "•";
}
.notification-dialog.android-style .notification-header .close-button {
  display: flex;
  width: 24px;
  height: 24px;
  align-items: center;
  justify-content: center;
  font-size: 20px;
  color: #939393;
}
.notification-dialog.android-style .notification-header .close-button:hover, .notification-dialog.android-style .notification-header .close-button:active {
  color: #4F5050;
}
.notification-dialog.android-style .notification-content {
  font-size: 13px;
  line-height: 1.4em;
  margin-top: 14px;
  display: flex;
  align-items: flex-start;
  justify-content: space-between;
}
.notification-dialog.android-style .notification-content .subtitle {
  font-size: 15px;
  margin: 0 0 5px 0;
  line-height: 1.4em;
  font-weight: 500;
}
.notification-dialog.android-style .notification-content .in {
  padding-right: 16px;
}
.notification-dialog.android-style .icon-box {
  width: 46px;
  height: 46px;
  font-size: 46px;
  color: #939393;
}
.notification-dialog.android-style .notification-footer {
  border-top: 1px solid #E1E1E1;
  margin: 16px -16px -16px -16px;
  padding: 0;
  display: flex;
  align-items: flex-start;
}
.notification-dialog.android-style .notification-footer .notification-button {
  flex: 1;
  display: flex;
  align-items: center;
  justify-content: center;
  color: #2E2481 !important;
  font-size: 13px;
  border-right: 1px solid #E1E1E1;
  padding: 16px 6px;
}
.notification-dialog.android-style .notification-footer .notification-button i.bi,
.notification-dialog.android-style .notification-footer .notification-button i.icon,
.notification-dialog.android-style .notification-footer .notification-button ion-icon {
  font-size: 20px;
  line-height: 1em;
  margin-right: 8px;
}
.notification-dialog.android-style .notification-footer .notification-button:last-child {
  border-right: 0;
}
.notification-dialog.android-style .notification-footer .notification-button:hover, .notification-dialog.android-style .notification-footer .notification-button:active {
  color: #271e6d;
  background: rgba(225, 225, 225, 0.3);
}

.notification-dialog.ios-style {
  margin: 10px;
  background: #3b4859;
  padding: 0;
  border-radius: 10px;
  box-shadow: 0 1px 3px 0 rgba(0, 0, 0, 0.08);
  overflow: hidden;
}
.notification-dialog.ios-style .notification-header {
  display: flex;
  align-items: center;
  justify-content: space-between;
  padding: 10px;
  background: rgba(0, 0, 0, 0.1);
  border-radius: 10px 10px 0 0;
}
.notification-dialog.ios-style .notification-header .in {
  display: flex;
  align-items: center;
}
.notification-dialog.ios-style .notification-header .in .imaged {
  margin-right: 8px;
}
.notification-dialog.ios-style .notification-header .in strong {
  font-size: 13px;
  font-weight: 400;
  color: #fff;
}
.notification-dialog.ios-style .notification-header .right {
  display: flex;
  align-items: center;
}
.notification-dialog.ios-style .notification-header .right span {
  display: inline-flex;
  align-items: center;
  margin-right: 6px;
  color: rgba(255, 255, 255, 0.5);
  font-size: 11px;
}
.notification-dialog.ios-style .notification-header .close-button {
  display: flex;
  width: 24px;
  height: 24px;
  align-items: center;
  justify-content: center;
  font-size: 20px;
  color: #fff;
  opacity: 0.5;
}
.notification-dialog.ios-style .notification-header .close-button:hover, .notification-dialog.ios-style .notification-header .close-button:active {
  opacity: 0.7;
}
.notification-dialog.ios-style .icon-box {
  width: 46px;
  height: 46px;
  font-size: 46px;
  color: #939393;
}
.notification-dialog.ios-style .notification-content {
  font-size: 13px;
  line-height: 1.4em;
  padding: 14px 16px 20px 16px;
  display: flex;
  align-items: flex-start;
  justify-content: space-between;
  color: rgba(255, 255, 255, 0.75);
}
.notification-dialog.ios-style .notification-content .subtitle {
  font-size: 15px;
  margin: 0 0 5px 0;
  line-height: 1.4em;
  color: #fff;
  font-weight: 500;
}
.notification-dialog.ios-style .notification-content .in {
  padding-right: 16px;
}
.notification-dialog.ios-style .notification-footer {
  border-top: 1px solid rgba(255, 255, 255, 0.1);
  padding: 0;
  display: flex;
  align-items: flex-start;
}
.notification-dialog.ios-style .notification-footer .notification-button {
  color: #fff !important;
  flex: 1;
  display: flex;
  align-items: center;
  justify-content: center;
  font-size: 13px;
  border-right: 1px solid rgba(255, 255, 255, 0.1);
  padding: 15px 6px;
}
.notification-dialog.ios-style .notification-footer .notification-button i.bi,
.notification-dialog.ios-style .notification-footer .notification-button i.icon,
.notification-dialog.ios-style .notification-footer .notification-button ion-icon {
  font-size: 20px;
  line-height: 1em;
  margin-right: 10px;
  color: #fff;
}
.notification-dialog.ios-style .notification-footer .notification-button:last-child {
  border-right: 0;
}
.notification-dialog.ios-style .notification-footer .notification-button:hover, .notification-dialog.ios-style .notification-footer .notification-button:active {
  color: #271e6d;
  background: rgba(255, 255, 255, 0.02);
}

.toast-box {
  position: fixed;
  left: 0;
  top: -100%;
  right: 0;
  width: 100%;
  z-index: 600;
  min-height: 52px;
  margin-top: env(safe-area-inset-top);
  transition: 0.2s all;
  background: #2b3543;
  font-size: 13px;
  color: rgba(255, 255, 255, 0.75);
  padding: 10px 16px;
  line-height: 1.4em;
  display: flex;
  align-items: center;
  justify-content: space-between;
}
.toast-box .toast-title {
  font-size: 15px;
  color: #FFF;
}
.toast-box .btn {
  font-size: 13px;
  font-weight: 500;
}
.toast-box.show {
  top: 0;
}
.toast-box .in {
  display: flex;
  align-items: center;
  justify-content: flex-start;
  padding-right: 20px;
}
.toast-box .in i.bi,
.toast-box .in i.icon,
.toast-box .in ion-icon {
  font-size: 24px;
  display: inline-flex;
  align-items: center;
  justify-content: center;
  width: 32px;
  height: 32px;
  margin-right: 8px;
  color: #FFF;
}
.toast-box .in .text {
  width: 100%;
}
.toast-box.toast-top.show {
  top: 56px;
}
.toast-box.toast-bottom {
  top: auto;
  bottom: -100%;
}
.toast-box.toast-bottom.show {
  bottom: 56px;
  top: auto;
  margin-bottom: env(safe-area-inset-bottom);
}
.toast-box.toast-center {
  width: auto;
  left: auto;
  right: auto;
  top: 50%;
  left: 50%;
  transform: translate(-50%, -50%);
  display: none;
  padding: 16px 24px;
  border-radius: 24px;
  text-align: center;
}
.toast-box.toast-center.show {
  display: block;
  transform: translate(-50%, -50%);
}
.toast-box.toast-center .in {
  padding: 0;
  display: block;
}
.toast-box.toast-center .in i.bi,
.toast-box.toast-center .in i.icon,
.toast-box.toast-center .in ion-icon {
  margin: 0 0 10px 0;
  font-size: 64px;
  width: 64px;
  height: 64px;
}
.toast-box.toast-center .btn {
  margin-top: 20px;
}

.extra-header-active .toast-box.toast-top.show {
  top: 95px;
}

.divider {
  height: 1px;
  background: #E1E1E1;
  display: flex;
  align-items: center;
  justify-content: center;
}
.divider .icon-box {
  background: #E1E1E1;
  display: flex;
  align-items: center;
  justify-content: center;
  color: #FFF;
  border-radius: 100%;
  width: 28px;
  height: 28px;
  font-size: 18px;
}
.divider.inset {
  margin-left: 16px;
  margin-right: 16px;
}

.comment-block {
  font-size: 13px;
  line-height: 1.6em;
}
.comment-block .item {
  display: flex;
  align-items: flex-start;
  margin-bottom: 30px;
}
.comment-block .item:last-child {
  margin-bottom: 0;
}
.comment-block .item .avatar {
  margin-right: 14px;
}
.comment-block .item .in {
  width: 100%;
}
.comment-block .item .text {
  color: #4F5050;
}
.comment-block .item .comment-header {
  display: flex;
  align-items: center;
  justify-content: space-between;
  margin-bottom: 4px;
}
.comment-block .item .comment-header .title {
  margin: 0;
  padding-right: 10px;
  color: #1c1b1b;
  font-size: 15px;
}
.comment-block .item .comment-header .time {
  font-size: 11px;
  color: #939393;
}
.comment-block .item .comment-footer {
  margin-top: 10px;
  display: flex;
  align-content: flex-start;
  font-size: 11px;
}
.comment-block .item .comment-footer .comment-button {
  font-weight: 500;
  display: flex;
  align-content: center;
  margin-right: 14px;
  color: #4F5050 !important;
}
.comment-block .item .comment-footer .comment-button i.bi,
.comment-block .item .comment-footer .comment-button i.icon,
.comment-block .item .comment-footer .comment-button ion-icon {
  margin-right: 5px;
  font-size: 18px;
  line-height: 1em;
}

.comment-box {
  padding: 24px 16px;
  text-align: center;
}
.comment-box .imaged {
  margin: 0 auto 10px auto;
  box-shadow: 0px 4px 4px rgba(0, 0, 0, 0.25);
}
.comment-box .card-title {
  margin: 0;
  font-size: 17px;
  font-weight: 500;
}
.comment-box .card-text {
  font-size: 11px;
}
.comment-box .text {
  margin-top: 6px;
}

.pagination {
  margin: 0;
  padding: 0;
  text-align: center;
  margin: auto;
  display: flex;
  align-items: center;
  justify-content: center;
}
.pagination .page-item .page-link {
  background: #2E2481;
  border: 0;
  color: #FFF;
  box-shadow: 0 !important;
  outline: 0 !important;
  margin: 0 4px;
  border-radius: 24px !important;
  font-size: 13px;
}
.pagination .page-item .page-link:focus {
  box-shadow: none !important;
}
.pagination.pagination-secondary .page-item .page-link {
  background: #FFF;
  color: #4F5050;
  box-shadow: 0px 4px 4px rgba(0, 0, 0, 0.25);
}
.pagination.pagination-rounded .page-item .page-link {
  border-radius: 400px !important;
}
.pagination.pagination-square .page-item .page-link {
  border-radius: 0 !important;
}

.error-page {
  text-align: center;
  padding: 40px 16px;
  max-width: 300px;
  margin: auto;
}
.error-page .icon-box {
  font-size: 86px;
  margin-bottom: 20px;
}
.error-page .title {
  font-size: 24px;
  margin-bottom: 20px;
}

#countDown {
  font-size: 20px;
  font-weight: 700;
  text-transform: uppercase;
  color: #1c1b1b;
  margin: 0 -40px;
}
#countDown .alert {
  width: 100%;
  margin: 0;
  text-transform: none;
}
#countDown > div {
  display: inline-block;
  width: 70px;
  border: 1px solid #E1E1E1;
  margin: 5px;
  text-align: center;
  border-radius: 24px;
  padding: 10px 5px;
}
#countDown > div p {
  margin: 0;
}
#countDown > div span {
  display: block;
  font-weight: 400;
  color: #939393;
  font-size: 10px;
}

#offline-toast,
#online-toast {
  color: #FFF;
  font-weight: 500;
}

.ios-add-to-home .action-sheet-content {
  position: relative;
  font-size: 13px;
  color: #1c1b1b;
  line-height: 1.5em;
}
.ios-add-to-home .action-sheet-content i.bi,
.ios-add-to-home .action-sheet-content i.icon,
.ios-add-to-home .action-sheet-content ion-icon {
  font-size: 22px;
  margin-bottom: -4px;
}
.ios-add-to-home:before {
  content: "";
  display: block;
  width: 0;
  height: 0;
  border-left: 14px solid transparent;
  border-right: 14px solid transparent;
  border-top: 10px solid #fff;
  position: absolute;
  bottom: -7px;
  z-index: 10;
  left: 50%;
  margin-left: -16px;
}

.android-add-to-home {
  bottom: auto !important;
  padding-top: 0;
  margin-top: env(safe-area-inset-top);
  top: 16px;
  left: 6px !important;
  right: 6px !important;
  z-index: 99999;
  border-radius: 6px !important;
}
.android-add-to-home .action-sheet-content {
  font-size: 13px;
  color: #1c1b1b;
  line-height: 1.5em;
}
.android-add-to-home .action-sheet-content h4 {
  font-size: 15px;
  margin-bottom: 10px;
}
.android-add-to-home .action-sheet-content i.bi,
.android-add-to-home .action-sheet-content i.icon,
.android-add-to-home .action-sheet-content ion-icon {
  font-size: 20px;
  margin-bottom: -5px;
}
.android-add-to-home:before {
  content: "";
  display: block;
  width: 0;
  height: 0;
  border-left: 14px solid transparent;
  border-right: 14px solid transparent;
  border-top: 10px solid #fff;
  position: absolute;
  top: -7px;
  z-index: 10;
  right: 8px;
  transform: rotate(180deg);
  margin-left: -16px;
}

.android-add-to-home2 {
  z-index: 200000;
}
.android-add-to-home2 .modal-dialog {
  top: 0;
  bottom: auto;
  padding: 6px !important;
  transform: translate(0, -100%) !important;
  transition: 0.5s all !important;
}
.android-add-to-home2.show .modal-dialog {
  transform: translate(0, 0) !important;
  top: 10px;
}
.android-add-to-home2 .modal-content {
  position: relative;
  z-index: 1;
  border-radius: 4px !important;
}
.android-add-to-home2 .modal-content:before {
  content: "";
  display: block;
  width: 0;
  height: 0;
  border-left: 14px solid transparent;
  border-right: 14px solid transparent;
  border-top: 10px solid #fff;
  position: absolute;
  top: -7px;
  z-index: 10;
  right: 9px;
  transform: rotate(180deg);
  margin-left: -16px;
}
.android-add-to-home2 .modal-content .action-sheet-content {
  font-size: 13px;
  color: #1c1b1b;
  line-height: 1.5em;
}
.android-add-to-home2 .modal-content .action-sheet-content h4 {
  font-size: 15px;
  margin-bottom: 10px;
}
.android-add-to-home2 .modal-content .action-sheet-content i.bi,
.android-add-to-home2 .modal-content .action-sheet-content i.icon,
.android-add-to-home2 .modal-content .action-sheet-content ion-icon {
  font-size: 20px;
  margin-bottom: -5px;
}

.button.goTop {
  width: 46px;
  height: 46px;
  display: none;
  align-items: center;
  justify-content: center;
  border-radius: 100px;
  background: #53AAC6;
  color: #FFF;
  position: fixed;
  z-index: 99;
  right: 16px;
  bottom: 70px;
  font-size: 18px;
  margin-bottom: env(safe-area-inset-bottom);
  box-shadow: 0px 4px 4px rgba(0, 0, 0, 0.25);
}
.button.goTop:hover, .button.goTop:active {
  background: #40a1c0;
}
.button.goTop.show {
  display: flex;
}

.needs-validation.was-validated .form-group.basic .invalid-feedback,
.needs-validation.was-validated .form-group.basic .valid-feedback,
.needs-validation.was-validated .form-group.boxed .invalid-feedback,
.needs-validation.was-validated .form-group.boxed .valid-feedback {
  height: 16px;
  font-size: 11px;
  line-height: 1.4em;
  margin-top: 4px;
}
.needs-validation.was-validated .form-group.basic .invalid-feedback,
.needs-validation.was-validated .form-group.boxed .invalid-feedback {
  color: #FB9393;
}
.needs-validation.was-validated .form-group.basic .valid-feedback,
.needs-validation.was-validated .form-group.boxed .valid-feedback {
  color: #C7FB93;
}
.needs-validation.was-validated .form-group.basic .clear-input,
.needs-validation.was-validated .form-group.boxed .clear-input {
  bottom: 20px;
}

.form-control.is-valid,
.was-validated .form-control:valid {
  border-color: #C7FB93;
  box-shadow: 0 !important;
  background-image: none !important;
}

.form-control.is-valid:focus,
.was-validated .form-control:valid:focus {
  border-color: #C7FB93;
  box-shadow: none !important;
}

.custom-select.is-valid,
.was-validated .custom-select:valid {
  border-color: #C7FB93;
}

.custom-select.is-valid:focus,
.was-validated .custom-select:valid:focus {
  border-color: #C7FB93;
  box-shadow: none !important;
}

.form-check-input.is-valid ~ .form-check-label,
.was-validated .form-check-input:valid ~ .form-check-label {
  color: #C7FB93;
}

.custom-control-input.is-valid ~ .custom-control-label,
.was-validated .custom-control-input:valid ~ .custom-control-label {
  color: #C7FB93;
}

.custom-control-input.is-valid ~ .custom-control-label::before,
.was-validated .custom-control-input:valid ~ .custom-control-label::before {
  border-color: #C7FB93;
}

.custom-control-input.is-valid:checked ~ .custom-control-label::before,
.was-validated .custom-control-input:valid:checked ~ .custom-control-label::before {
  border-color: #C7FB93;
  background-color: #C7FB93;
}

.custom-control-input.is-valid:focus ~ .custom-control-label::before,
.was-validated .custom-control-input:valid:focus ~ .custom-control-label::before {
  box-shadow: none !important;
}

.custom-control-input.is-valid:focus:not(:checked) ~ .custom-control-label::before,
.was-validated .custom-control-input:valid:focus:not(:checked) ~ .custom-control-label::before {
  border-color: #C7FB93;
}

.custom-file-input.is-valid ~ .custom-file-label,
.was-validated .custom-file-input:valid ~ .custom-file-label {
  border-color: #C7FB93;
}

.custom-file-input.is-valid:focus ~ .custom-file-label,
.was-validated .custom-file-input:valid:focus ~ .custom-file-label {
  border-color: #C7FB93;
  box-shadow: none !important;
}

.form-control.is-invalid,
.was-validated .form-control:invalid {
  border-color: #FB9393;
  background-image: none !important;
}

.form-control.is-invalid:focus,
.was-validated .form-control:invalid:focus {
  border-color: #FB9393;
  box-shadow: none !important;
}

.custom-select.is-invalid,
.was-validated .custom-select:invalid {
  border-color: #FB9393;
}

.custom-select.is-invalid:focus,
.was-validated .custom-select:invalid:focus {
  border-color: #FB9393;
  box-shadow: none !important;
}

.form-check-input.is-invalid ~ .form-check-label,
.was-validated .form-check-input:invalid ~ .form-check-label {
  color: #FB9393;
}

.custom-control-input.is-invalid ~ .custom-control-label,
.was-validated .custom-control-input:invalid ~ .custom-control-label {
  color: #FB9393;
}

.custom-control-input.is-invalid ~ .custom-control-label::before,
.was-validated .custom-control-input:invalid ~ .custom-control-label::before {
  border-color: #FB9393;
}

.custom-control-input.is-invalid:checked ~ .custom-control-label::before,
.was-validated .custom-control-input:invalid:checked ~ .custom-control-label::before {
  border-color: #FB9393;
  background-color: #FB9393;
}

.custom-control-input.is-invalid:focus:not(:checked) ~ .custom-control-label::before,
.was-validated .custom-control-input:invalid:focus:not(:checked) ~ .custom-control-label::before {
  border-color: #FB9393;
}

.custom-file-input.is-invalid ~ .custom-file-label,
.was-validated .custom-file-input:invalid ~ .custom-file-label {
  border-color: #FB9393;
}

.custom-file-input.is-invalid:focus ~ .custom-file-label,
.was-validated .custom-file-input:invalid:focus ~ .custom-file-label {
  border-color: #FB9393;
  box-shadow: none !important;
}

.blog-post .title {
  padding: 0px 16px;
  margin: 0 0 10px 0;
}
.blog-post .post-header {
  font-size: 11px;
  padding: 10px 0;
  margin: 16px 16px;
  color: #939393;
  display: flex;
  align-items: center;
  justify-content: space-between;
  border-top: 1px solid #E1E1E1;
  border-bottom: 1px solid #E1E1E1;
}
.blog-post .post-header a {
  color: #1c1b1b;
  font-weight: 700;
}
.blog-post .post-body {
  padding: 0 16px;
}
.blog-post .post-body img {
  width: calc(100% + 32px);
  height: auto;
  margin: 0px -16px;
  margin-bottom: 16px;
}

.profile-head {
  display: flex;
  align-items: center;
}
.profile-head .avatar {
  margin-right: 16px;
}
.profile-head .in .name {
  margin: 0 0 5px 0;
  font-weight: 500;
}
.profile-head .in .subtext {
  color: #939393;
  font-weight: 400;
  margin: 0;
}

.profile-info {
  font-size: 13px;
  line-height: 1.5em;
}
.profile-info .bio {
  color: #4F5050;
}
.profile-info .link {
  margin-top: 4px;
  color: #2E2481;
}

.profile-stats {
  display: flex;
  align-items: center;
  justify-content: space-between;
}
.profile-stats .item {
  font-size: 11px;
  line-height: 1.6em;
  padding: 5px;
  color: #4F5050;
  text-align: center;
}
.profile-stats .item:last-child {
  border-right-color: transparent;
}
.profile-stats .item strong {
  display: block;
  line-height: 1.4em;
  color: #1c1b1b;
  font-size: 17px;
}

.stepper {
  height: 40px;
  width: 120px;
  min-width: 120px;
  border-radius: 24px;
  display: inline-flex;
  align-items: flex-start;
  justify-content: space-between;
  overflow: hidden;
}
.stepper .stepper-button {
  width: 40px;
  height: 40px;
  color: #fff;
  display: flex;
  font-size: 24px;
  align-items: center;
  justify-content: center;
  background: #2E2481;
  position: relative;
  border: 2px solid #2E2481;
}
.stepper .form-control {
  padding: 0 3px;
  width: 52px;
  height: 40px;
  border-radius: 0;
  box-shadow: none !important;
  background: transparent;
  text-align: center;
  border: 2px solid #2E2481;
  font-size: 17px;
  font-weight: 500;
  color: #2E2481;
}

.stepper-sm {
  height: 30px;
  width: 80px;
  min-width: 80px;
}
.stepper-sm .stepper-button {
  height: 30px;
  width: 24px;
  font-size: 17px;
}
.stepper-sm .form-control {
  height: 30px;
  width: 32px;
  font-size: 15px;
}

.stepper-lg {
  height: 48px;
}
.stepper-lg .stepper-button {
  height: 48px;
  font-size: 24px;
}
.stepper-lg .form-control {
  height: 48px;
}

.stepper-primary .stepper-button {
  background: #2E2481;
  border-color: #2E2481;
}
.stepper-primary .form-control {
  border-color: #2E2481;
  color: #2E2481;
}

.stepper-secondary .stepper-button {
  background: #53AAC6;
  border-color: #53AAC6;
}
.stepper-secondary .form-control {
  border-color: #53AAC6;
  color: #53AAC6;
}

.stepper-success .stepper-button {
  background: #C7FB93;
  border-color: #C7FB93;
}
.stepper-success .form-control {
  border-color: #C7FB93;
  color: #C7FB93;
}

.stepper-danger .stepper-button {
  background: #FB9393;
  border-color: #FB9393;
}
.stepper-danger .form-control {
  border-color: #FB9393;
  color: #FB9393;
}

.stepper-warning .stepper-button {
  background: #FBC593;
  border-color: #FBC593;
}
.stepper-warning .form-control {
  border-color: #FBC593;
  color: #FBC593;
}

.stepper-info .stepper-button {
  background: #ffffff;
  border-color: #ffffff;
}
.stepper-info .form-control {
  border-color: #ffffff;
  color: #ffffff;
}

.stepper-dark .stepper-button {
  background: #333;
  border-color: #333;
}
.stepper-dark .form-control {
  border-color: #333;
  color: #333;
}

.stepper-outline-primary .stepper-button {
  background: transparent;
  color: #2E2481;
  border-color: #2E2481;
}
.stepper-outline-primary .stepper-button.stepper-down {
  border-radius: 24px 0 0 24px;
}
.stepper-outline-primary .stepper-button.stepper-up {
  border-radius: 0 24px 24px 0;
}
.stepper-outline-primary .stepper-button:first-child {
  border-right: 0;
}
.stepper-outline-primary .stepper-button:last-child {
  border-left: 0;
}
.stepper-outline-primary .form-control {
  border-color: #2E2481;
  color: #2E2481;
}

.stepper-outline-secondary .stepper-button {
  background: transparent;
  color: #53AAC6;
  border-color: #53AAC6;
}
.stepper-outline-secondary .stepper-button.stepper-down {
  border-radius: 24px 0 0 24px;
}
.stepper-outline-secondary .stepper-button.stepper-up {
  border-radius: 0 24px 24px 0;
}
.stepper-outline-secondary .stepper-button:first-child {
  border-right: 0;
}
.stepper-outline-secondary .stepper-button:last-child {
  border-left: 0;
}
.stepper-outline-secondary .form-control {
  border-color: #53AAC6;
  color: #53AAC6;
}

.stepper-outline-success .stepper-button {
  background: transparent;
  color: #C7FB93;
  border-color: #C7FB93;
}
.stepper-outline-success .stepper-button.stepper-down {
  border-radius: 24px 0 0 24px;
}
.stepper-outline-success .stepper-button.stepper-up {
  border-radius: 0 24px 24px 0;
}
.stepper-outline-success .stepper-button:first-child {
  border-right: 0;
}
.stepper-outline-success .stepper-button:last-child {
  border-left: 0;
}
.stepper-outline-success .form-control {
  border-color: #C7FB93;
  color: #C7FB93;
}

.stepper-outline-danger .stepper-button {
  background: transparent;
  color: #FB9393;
  border-color: #FB9393;
}
.stepper-outline-danger .stepper-button.stepper-down {
  border-radius: 24px 0 0 24px;
}
.stepper-outline-danger .stepper-button.stepper-up {
  border-radius: 0 24px 24px 0;
}
.stepper-outline-danger .stepper-button:first-child {
  border-right: 0;
}
.stepper-outline-danger .stepper-button:last-child {
  border-left: 0;
}
.stepper-outline-danger .form-control {
  border-color: #FB9393;
  color: #FB9393;
}

.stepper-outline-warning .stepper-button {
  background: transparent;
  color: #FBC593;
  border-color: #FBC593;
}
.stepper-outline-warning .stepper-button.stepper-down {
  border-radius: 24px 0 0 24px;
}
.stepper-outline-warning .stepper-button.stepper-up {
  border-radius: 0 24px 24px 0;
}
.stepper-outline-warning .stepper-button:first-child {
  border-right: 0;
}
.stepper-outline-warning .stepper-button:last-child {
  border-left: 0;
}
.stepper-outline-warning .form-control {
  border-color: #FBC593;
  color: #FBC593;
}

.stepper-outline-info .stepper-button {
  background: transparent;
  color: #ffffff;
  border-color: #ffffff;
}
.stepper-outline-info .stepper-button.stepper-down {
  border-radius: 24px 0 0 24px;
}
.stepper-outline-info .stepper-button.stepper-up {
  border-radius: 0 24px 24px 0;
}
.stepper-outline-info .stepper-button:first-child {
  border-right: 0;
}
.stepper-outline-info .stepper-button:last-child {
  border-left: 0;
}
.stepper-outline-info .form-control {
  border-color: #ffffff;
  color: #ffffff;
}

.stepper-outline-dark .stepper-button {
  background: transparent;
  color: #333;
  border-color: #333;
}
.stepper-outline-dark .stepper-button.stepper-down {
  border-radius: 24px 0 0 24px;
}
.stepper-outline-dark .stepper-button.stepper-up {
  border-radius: 0 24px 24px 0;
}
.stepper-outline-dark .stepper-button:first-child {
  border-right: 0;
}
.stepper-outline-dark .stepper-button:last-child {
  border-left: 0;
}
.stepper-outline-dark .form-control {
  border-color: #333;
  color: #333;
}

.rate-block {
  font-size: 18px;
  display: flex;
  color: #939393;
}
.rate-block i.bi,
.rate-block ion-icon,
.rate-block i.icon {
  margin-right: 3px;
}
.rate-block i.bi.active,
.rate-block ion-icon.active,
.rate-block i.icon.active {
  color: #FBC593;
}

.comment-block .rate-block {
  font-size: 14px;
}

.product-detail-header .title {
  margin: 0 0 2px 0;
  font-weight: 500;
  font-size: 17px;
  color: #1c1b1b;
}
.product-detail-header .text {
  font-size: 13px;
  color: #4F5050;
}
.product-detail-header .detail-footer {
  margin: 16px 0;
  display: flex;
  align-items: center;
  justify-content: space-between;
}
.product-detail-header .detail-footer .price .old-price {
  font-size: 15px;
  color: #4F5050;
  text-decoration: line-through;
  margin-bottom: 4px;
}
.product-detail-header .detail-footer .price .current-price {
  font-size: 24px;
  color: #2E2481;
  font-weight: 500;
}

.cart-item .card-body {
  padding: 16px;
}
.cart-item .imaged {
  width: 80px;
  height: auto;
}
.cart-item .in {
  display: flex;
  align-items: center;
}
.cart-item .in .text {
  margin-left: 16px;
}
.cart-item .in .text .title {
  font-weight: 500;
  font-size: 15px;
  line-height: 1.2em;
  margin: 0 0 6px 0;
}
.cart-item .in .text .detail {
  line-height: 1.2em;
  margin: 0 0 4px 0;
  font-size: 11px;
  color: #939393;
}
.cart-item .in .text .price {
  font-weight: 500;
  font-size: 15px;
  color: #2E2481;
}
.cart-item .cart-item-footer {
  border-top: 1px solid #E1E1E1;
  padding: 16px 0 0 0;
  margin: 16px 0 0 0;
  display: flex;
  align-items: center;
  justify-content: space-between;
}

.invoiceBackgroundLogo {
  position: absolute;
  left: 5%;
  top: 50%;
  transform: translate(0, -50%) rotate(25deg);
}
.invoiceBackgroundLogo img {
  opacity: 0.1;
  width: 90%;
}

.invoice {
  background: #FFF;
  box-shadow: 0px 4px 4px rgba(0, 0, 0, 0.25);
  padding: 24px 16px;
  margin: 8px;
  position: relative;
  overflow: hidden;
}
.invoice .invoice-page-header {
  display: flex;
  align-items: flex-end;
  justify-content: space-between;
}
.invoice .invoice-page-header .invoice-logo img {
  height: 20px;
}
.invoice .invoice-page-header .invoice-id {
  font-size: 11px;
  color: #4F5050;
}
.invoice .invoice-person {
  display: flex;
  align-items: flex-start;
  justify-content: space-between;
}
.invoice .invoice-person .invoice-to,
.invoice .invoice-person .invoice-from {
  font-size: 11px;
}
.invoice .invoice-person .invoice-to h4,
.invoice .invoice-person .invoice-from h4 {
  margin-bottom: 8px;
  color: #1c1b1b;
  font-size: 13px;
}
.invoice .invoice-person .invoice-to p,
.invoice .invoice-person .invoice-from p {
  margin: 0 0 3px 0;
  line-height: 1.4em;
  color: #939393;
}
.invoice .invoice-person .invoice-to {
  padding-right: 12px;
}
.invoice .invoice-person .invoice-from {
  text-align: right;
  padding-left: 12px;
}
.invoice .invoice-detail .table {
  border-bottom: 1px solid #E1E1E1;
}
.invoice .invoice-detail .table thead,
.invoice .invoice-detail .table tbody {
  font-size: 11px;
  font-weight: 700;
}
.invoice .invoice-detail .table thead td,
.invoice .invoice-detail .table tbody td {
  text-align: center;
}
.invoice .invoice-detail .table thead td:first-child,
.invoice .invoice-detail .table tbody td:first-child {
  text-align: left;
  padding-left: 0;
}
.invoice .invoice-detail .table thead td:last-child,
.invoice .invoice-detail .table tbody td:last-child {
  padding-right: 0;
  text-align: right;
}
.invoice .invoice-detail .table thead {
  color: #939393;
}
.invoice .invoice-detail .table tbody {
  color: #1c1b1b;
}
.invoice .invoice-total {
  font-size: 11px;
  font-weight: 700;
}
.invoice .invoice-total .listview {
  padding: 0;
}
.invoice .invoice-total .listview li {
  min-height: auto;
  padding: 12px 0;
}
.invoice .invoice-total .listview li .hightext {
  font-size: 13px;
}
.invoice .invoice-total .listview li .totaltext {
  font-size: 17px;
}
.invoice .invoice-signature .signature-block {
  display: inline-flex;
  font-size: 11px;
  padding: 5px 32px 42px 32px;
  border: 2px dashed #E1E1E1;
}
.invoice .invoice-bottom {
  font-size: 10px;
  text-align: center;
  padding-top: 24px;
  opacity: 0.4;
}

.story-block .splide__slide {
  padding-top: 5px;
  padding-bottom: 5px;
  padding-right: 26px !important;
  margin-right: -10px !important;
}
.story-block .splide__slide img {
  box-shadow: 0 0 0 3px #ffffff, 0 0 0 5px #2E2481;
}
.story-block .seen img {
  box-shadow: 0 0 0 4px #ffffff, 0 0 0 5px #939393;
}
.story-block .passive img {
  box-shadow: 0 0 0 4px #ffffff, 0 0 0 5px #939393;
  filter: grayscale(100%) opacity(50%);
}

.modal.stories {
  padding-top: env(safe-area-inset-top);
  overflow: hidden;
}
.modal.stories .modal-dialog {
  transform: translate(0, 100%) scale(0.1) !important;
  min-width: 100%;
  margin: 0;
  transition: 0.2s ease-in-out !important;
  position: fixed;
  left: 0;
  top: 0;
  right: 0;
  bottom: 0;
  margin-top: env(safe-area-inset-top);
}
.modal.stories .modal-dialog .modal-content {
  border-radius: 0;
  border: 0;
  margin: auto;
  overflow: hidden;
  padding-top: 56px;
  position: absolute;
  left: 0;
  right: 0;
  bottom: 0;
  top: 0;
}
.modal.stories .modal-dialog .modal-content .modal-header {
  border: 0;
  padding: 0;
  min-height: 56px;
  padding: 16px 16px 42px 16px;
  border-radius: 0;
  display: flex;
  align-items: center;
  justify-content: space-between;
  margin: 0;
  position: fixed;
  left: 0;
  right: 0;
  top: 0;
  width: 100%;
  z-index: 100;
  background: transparent;
  background-image: linear-gradient(-180deg, rgba(0, 0, 0, 0.85) 0%, rgba(0, 0, 0, 0) 100%);
}
.modal.stories .modal-dialog .modal-content .modal-header .modal-title {
  margin: 0;
  color: #1c1b1b;
  font-size: 17px;
}
.modal.stories .modal-dialog .modal-content .modal-body {
  display: flex;
  align-items: center;
  justify-content: center;
  color: #fff;
  padding: 100px 24px;
}
.modal.stories .modal-dialog .modal-content .modal-body p {
  text-shadow: 0 3px 6px rgba(0, 0, 0, 0.59);
  opacity: 0.9;
}
.modal.stories .modal-dialog .modal-content .modal-body h1,
.modal.stories .modal-dialog .modal-content .modal-body h2,
.modal.stories .modal-dialog .modal-content .modal-body h3,
.modal.stories .modal-dialog .modal-content .modal-body h4,
.modal.stories .modal-dialog .modal-content .modal-body h5 {
  color: #fff;
  text-shadow: 0 3px 6px rgba(0, 0, 0, 0.59);
}
.modal.stories .modal-dialog .modal-content .modal-body .btn {
  margin-top: 10px;
}
.modal.stories .modal-dialog .modal-content .modal-body .fixed-btn {
  position: absolute;
  left: 16px;
  right: 16px;
  bottom: 16px;
  margin-bottom: env(safe-area-inset-bottom);
}
.modal.stories.show .modal-dialog {
  transform: translate(0, 0) scale(1) !important;
}
.modal.stories.with-story-bar .modal-content .modal-header {
  padding-top: 32px;
}
.modal.stories .story-bar {
  height: 4px;
  border-radius: 12px;
  background: rgba(255, 255, 255, 0.2);
  position: absolute;
  left: 16px;
  right: 16px;
  z-index: 1000;
  top: 16px;
  overflow: hidden;
}
.modal.stories .story-bar span {
  display: block;
  height: 4px;
  width: 0%;
  background: #fff;
}
@keyframes storybar-animation {
  0% {
    width: 0;
  }
  100% {
    width: 100%;
  }
}
.modal.stories .story-image {
  position: absolute;
  left: 0;
  top: 0;
  right: 0;
  bottom: 0;
  overflow: hidden;
  background: #000;
}
.modal.stories .story-image img,
.modal.stories .story-image video {
  width: auto;
  height: 100vh;
  position: absolute;
  left: 50%;
  transform: translate(-50%, 0);
  top: 0;
}
.modal.stories .profile-detail {
  display: flex;
  align-items: center;
}
.modal.stories .profile-detail h4 {
  color: #fff;
  margin: 0;
  line-height: 1.2em;
  display: block;
}
.modal.stories .profile-detail .text-muted {
  display: block;
  font-size: 11px;
  color: #fff !important;
  opacity: 0.7;
  line-height: 1.3em;
}
.modal.stories .close-stories {
  color: #fff;
  font-size: 24px;
}
.modal.stories .close-stories:hover {
  opacity: 0.6;
}

html[dir=rtl],
body.rtl-mode {
  direction: rtl;
}
html[dir=rtl] .ms-0,
body.rtl-mode .ms-0 {
  margin-left: 0 !important;
  margin-right: 0 !important;
}
html[dir=rtl] .ms-05,
body.rtl-mode .ms-05 {
  margin-left: 0 !important;
  margin-right: 5px !important;
}
html[dir=rtl] .ms-1,
body.rtl-mode .ms-1 {
  margin-left: 0 !important;
  margin-right: 8px !important;
}
html[dir=rtl] .ms-2,
body.rtl-mode .ms-2 {
  margin-left: 0 !important;
  margin-right: 16px !important;
}
html[dir=rtl] .ms-3,
body.rtl-mode .ms-3 {
  margin-left: 0 !important;
  margin-right: 24px !important;
}
html[dir=rtl] .ms-4,
body.rtl-mode .ms-4 {
  margin-left: 0 !important;
  margin-right: 32px !important;
}
html[dir=rtl] .ms-5,
body.rtl-mode .ms-5 {
  margin-left: 0 !important;
  margin-right: 40px !important;
}
html[dir=rtl] .me-0,
body.rtl-mode .me-0 {
  margin-right: 0 !important;
  margin-left: 0px !important;
}
html[dir=rtl] .me-05,
body.rtl-mode .me-05 {
  margin-right: 0 !important;
  margin-left: 5px !important;
}
html[dir=rtl] .me-1,
body.rtl-mode .me-1 {
  margin-right: 0 !important;
  margin-left: 8px !important;
}
html[dir=rtl] .me-2,
body.rtl-mode .me-2 {
  margin-right: 0 !important;
  margin-left: 16px !important;
}
html[dir=rtl] .me-3,
body.rtl-mode .me-3 {
  margin-right: 0 !important;
  margin-left: 24px !important;
}
html[dir=rtl] .me-4,
body.rtl-mode .me-4 {
  margin-right: 0 !important;
  margin-left: 32px !important;
}
html[dir=rtl] .me-5,
body.rtl-mode .me-5 {
  margin-right: 0 !important;
  margin-left: 40px !important;
}
html[dir=rtl] .ps-0,
body.rtl-mode .ps-0 {
  padding-left: 0px !important;
  padding-right: 0px !important;
}
html[dir=rtl] .ps-05,
body.rtl-mode .ps-05 {
  padding-left: 0px !important;
  padding-right: 5px !important;
}
html[dir=rtl] .ps-1,
body.rtl-mode .ps-1 {
  padding-left: 0px !important;
  padding-right: 8px !important;
}
html[dir=rtl] .ps-2,
body.rtl-mode .ps-2 {
  padding-left: 0px !important;
  padding-right: 16px !important;
}
html[dir=rtl] .ps-3,
body.rtl-mode .ps-3 {
  padding-left: 0px !important;
  padding-right: 24px !important;
}
html[dir=rtl] .ps-4,
body.rtl-mode .ps-4 {
  padding-left: 0px !important;
  padding-right: 32px !important;
}
html[dir=rtl] .ps-5,
body.rtl-mode .ps-5 {
  padding-left: 0px !important;
  padding-right: 40px !important;
}
html[dir=rtl] .pe-0,
body.rtl-mode .pe-0 {
  padding-right: 0px !important;
  padding-left: 0px !important;
}
html[dir=rtl] .pe-05,
body.rtl-mode .pe-05 {
  padding-right: 0px !important;
  padding-left: 5px !important;
}
html[dir=rtl] .pe-1,
body.rtl-mode .pe-1 {
  padding-right: 0px !important;
  padding-left: 8px !important;
}
html[dir=rtl] .pe-2,
body.rtl-mode .pe-2 {
  padding-right: 0px !important;
  padding-left: 16px !important;
}
html[dir=rtl] .pe-3,
body.rtl-mode .pe-3 {
  padding-right: 0px !important;
  padding-left: 24px !important;
}
html[dir=rtl] .pe-4,
body.rtl-mode .pe-4 {
  padding-right: 0px !important;
  padding-left: 32px !important;
}
html[dir=rtl] .pe-5,
body.rtl-mode .pe-5 {
  padding-right: 0px !important;
  padding-left: 40px !important;
}
html[dir=rtl] .appHeader .left,
body.rtl-mode .appHeader .left {
  right: 10px;
  left: auto;
}
html[dir=rtl] .appHeader .right,
body.rtl-mode .appHeader .right {
  right: auto;
  left: 10px;
}
html[dir=rtl] .link-listview > li a,
html[dir=rtl] .image-listview > li a,
body.rtl-mode .link-listview > li a,
body.rtl-mode .image-listview > li a {
  padding: 11px 16px 11px 36px;
}
html[dir=rtl] .link-listview > li a:after,
html[dir=rtl] .image-listview > li a:after,
body.rtl-mode .link-listview > li a:after,
body.rtl-mode .image-listview > li a:after {
  right: auto;
  left: 16px;
  transform: rotate(180deg);
}
html[dir=rtl] .link-listview.text > li:after,
html[dir=rtl] .image-listview.text > li:after,
body.rtl-mode .link-listview.text > li:after,
body.rtl-mode .image-listview.text > li:after {
  left: 0;
  right: 16px;
}
html[dir=rtl] .link-listview.media > li .imageWrapper,
html[dir=rtl] .image-listview.media > li .imageWrapper,
body.rtl-mode .link-listview.media > li .imageWrapper,
body.rtl-mode .image-listview.media > li .imageWrapper {
  margin-right: 0;
  margin-left: 16px;
}
html[dir=rtl] .image-listview > li:after,
body.rtl-mode .image-listview > li:after {
  left: 0;
  right: 68px;
}
html[dir=rtl] .image-listview > li .item .image,
html[dir=rtl] .image-listview > li .item .icon-box,
body.rtl-mode .image-listview > li .item .image,
body.rtl-mode .image-listview > li .item .icon-box {
  margin-right: 0;
  margin-left: 16px;
}
html[dir=rtl] .accordion .accordion-header .btn,
html[dir=rtl] .accordion .accordion-header .accordion-button,
body.rtl-mode .accordion .accordion-header .btn,
body.rtl-mode .accordion .accordion-header .accordion-button {
  padding: 8px 16px 8px 50px;
}
html[dir=rtl] .accordion .accordion-header .btn:after,
html[dir=rtl] .accordion .accordion-header .accordion-button:after,
body.rtl-mode .accordion .accordion-header .btn:after,
body.rtl-mode .accordion .accordion-header .accordion-button:after {
  left: 10px;
  right: auto;
}
html[dir=rtl] .accordion .accordion-header .btn:before,
html[dir=rtl] .accordion .accordion-header .accordion-button:before,
body.rtl-mode .accordion .accordion-header .btn:before,
body.rtl-mode .accordion .accordion-header .accordion-button:before {
  left: 0;
  right: 16px;
}
html[dir=rtl] .accordion .accordion-header .btn i.bi,
html[dir=rtl] .accordion .accordion-header .btn i.icon,
html[dir=rtl] .accordion .accordion-header .btn ion-icon,
html[dir=rtl] .accordion .accordion-header .accordion-button i.bi,
html[dir=rtl] .accordion .accordion-header .accordion-button i.icon,
html[dir=rtl] .accordion .accordion-header .accordion-button ion-icon,
body.rtl-mode .accordion .accordion-header .btn i.bi,
body.rtl-mode .accordion .accordion-header .btn i.icon,
body.rtl-mode .accordion .accordion-header .btn ion-icon,
body.rtl-mode .accordion .accordion-header .accordion-button i.bi,
body.rtl-mode .accordion .accordion-header .accordion-button i.icon,
body.rtl-mode .accordion .accordion-header .accordion-button ion-icon {
  margin-right: 0;
  margin-left: 10px;
}
html[dir=rtl] .action-button-list > li .btn .icon,
html[dir=rtl] .action-button-list > li .btn ion-icon,
body.rtl-mode .action-button-list > li .btn .icon,
body.rtl-mode .action-button-list > li .btn ion-icon {
  margin-right: -5px;
  margin-left: 10px;
}
html[dir=rtl] .alert.alert-dismissible,
body.rtl-mode .alert.alert-dismissible {
  padding-right: 14px;
  padding-left: 56px;
}
html[dir=rtl] .alert .btn-close,
body.rtl-mode .alert .btn-close {
  left: 0;
  right: auto;
}
html[dir=rtl] .alert .img-wrap,
html[dir=rtl] .alert .icon-wrap,
body.rtl-mode .alert .img-wrap,
body.rtl-mode .alert .icon-wrap {
  margin-right: 0;
  margin-left: 10px;
}
html[dir=rtl] .btn-group .btn:last-child,
body.rtl-mode .btn-group .btn:last-child {
  border-radius: 24px 0 0 24px !important;
}
html[dir=rtl] .btn-group input[type=radio]:first-child + .btn,
html[dir=rtl] .btn-group input[type=checkbox]:first-child + .btn,
body.rtl-mode .btn-group input[type=radio]:first-child + .btn,
body.rtl-mode .btn-group input[type=checkbox]:first-child + .btn {
  border-radius: 0 24px 24px 0;
}
html[dir=rtl] .carousel-single .splide__slide,
html[dir=rtl] .carousel-multiple .splide__slide,
body.rtl-mode .carousel-single .splide__slide,
body.rtl-mode .carousel-multiple .splide__slide {
  margin-right: 0 !important;
  margin-left: 0 !important;
  padding-right: 0 !important;
  padding-left: 16px !important;
}
html[dir=rtl] .carousel-small .splide__slide,
body.rtl-mode .carousel-small .splide__slide {
  margin-right: 8px !important;
  margin-left: 0 !important;
  padding-right: 0 !important;
  padding-left: 0 !important;
}
html[dir=rtl] .form-check .form-check-label,
body.rtl-mode .form-check .form-check-label {
  padding: 0 32px 0 0;
}
html[dir=rtl] .form-check .form-check-label:after, html[dir=rtl] .form-check .form-check-label:before,
body.rtl-mode .form-check .form-check-label:after,
body.rtl-mode .form-check .form-check-label:before {
  left: auto;
  right: 0;
}
html[dir=rtl] .input-list .form-check:after,
body.rtl-mode .input-list .form-check:after {
  margin-left: auto;
  margin-right: 54px;
}
html[dir=rtl] .input-list .form-check .form-check-label,
body.rtl-mode .input-list .form-check .form-check-label {
  padding: 6px 54px 6px 16px;
}
html[dir=rtl] .input-list .form-check .form-check-label:after, html[dir=rtl] .input-list .form-check .form-check-label:before,
body.rtl-mode .input-list .form-check .form-check-label:after,
body.rtl-mode .input-list .form-check .form-check-label:before {
  right: 16px;
  left: auto;
}
html[dir=rtl] .chip.chip-media,
body.rtl-mode .chip.chip-media {
  padding-left: 0;
  padding-right: 20px;
}
html[dir=rtl] .chip .chip-icon,
html[dir=rtl] .chip img,
body.rtl-mode .chip .chip-icon,
body.rtl-mode .chip img {
  left: auto;
  right: 0;
}
html[dir=rtl] .chip .chip-delete,
body.rtl-mode .chip .chip-delete {
  margin-left: 0;
  margin-right: -10px;
}
html[dir=rtl] .dialogbox .modal-dialog .modal-content .btn-inline .btn,
body.rtl-mode .dialogbox .modal-dialog .modal-content .btn-inline .btn {
  border-radius: 0 !important;
  margin-left: 0;
  margin-right: 1px;
}
html[dir=rtl] .dialogbox .modal-dialog .modal-content .btn-inline .btn:last-child,
body.rtl-mode .dialogbox .modal-dialog .modal-content .btn-inline .btn:last-child {
  margin-right: 1px;
}
html[dir=rtl] .dialogbox .modal-dialog .modal-content .btn-inline .btn:first-child,
body.rtl-mode .dialogbox .modal-dialog .modal-content .btn-inline .btn:first-child {
  margin-right: 0;
}
html[dir=rtl] .btn i.icon,
html[dir=rtl] .btn ion-icon,
body.rtl-mode .btn i.icon,
body.rtl-mode .btn ion-icon {
  margin-right: 0;
  margin-left: 7px;
}
html[dir=rtl] .btn .spinner-border,
html[dir=rtl] .btn .spinner-grow,
body.rtl-mode .btn .spinner-border,
body.rtl-mode .btn .spinner-grow {
  margin-right: 5px;
  margin-left: 5px;
}
html[dir=rtl] .dropdown-toggle:after,
body.rtl-mode .dropdown-toggle:after {
  margin-left: 0;
  margin-right: 7px;
}
html[dir=rtl] .dropdown .dropdown-menu .icon,
html[dir=rtl] .dropdown .dropdown-menu ion-icon,
html[dir=rtl] .dropup .dropdown-menu .icon,
html[dir=rtl] .dropup .dropdown-menu ion-icon,
body.rtl-mode .dropdown .dropdown-menu .icon,
body.rtl-mode .dropdown .dropdown-menu ion-icon,
body.rtl-mode .dropup .dropdown-menu .icon,
body.rtl-mode .dropup .dropdown-menu ion-icon {
  margin-right: 0;
  margin-left: 6px;
}
html[dir=rtl] .form-group .form-label,
body.rtl-mode .form-group .form-label {
  text-align: start;
}
html[dir=rtl] .form-group .form-control,
body.rtl-mode .form-group .form-control {
  padding-right: 0;
  padding-left: 40px;
}
html[dir=rtl] .form-group select.form-control,
body.rtl-mode .form-group select.form-control {
  padding-left: 0;
}
html[dir=rtl] .form-group .clear-input,
body.rtl-mode .form-group .clear-input {
  left: -10px;
}
html[dir=rtl] .form-group.boxed .clear-input,
body.rtl-mode .form-group.boxed .clear-input {
  left: 0;
  right: auto;
}
html[dir=rtl] .form-group.boxed .form-control,
body.rtl-mode .form-group.boxed .form-control {
  padding-right: 16px;
}
html[dir=rtl] .form-group.basic .clear-input,
body.rtl-mode .form-group.basic .clear-input {
  left: -10px;
  right: auto;
}
html[dir=rtl] .message-item,
body.rtl-mode .message-item {
  direction: ltr;
}
html[dir=rtl] .notification-dialog.android-style .notification-header .imaged,
body.rtl-mode .notification-dialog.android-style .notification-header .imaged {
  margin-right: 0;
  margin-left: 8px;
}
html[dir=rtl] .notification-dialog.android-style .notification-header span,
body.rtl-mode .notification-dialog.android-style .notification-header span {
  margin-left: 0;
  margin-right: 6px;
}
html[dir=rtl] .notification-dialog.android-style .notification-header span:before,
body.rtl-mode .notification-dialog.android-style .notification-header span:before {
  margin-right: 0;
  margin-left: 6px;
}
html[dir=rtl] .notification-dialog.android-style .notification-content .in,
body.rtl-mode .notification-dialog.android-style .notification-content .in {
  padding-right: 0;
  padding-left: 16px;
}
html[dir=rtl] .notification-dialog.android-style .notification-footer .notification-button,
body.rtl-mode .notification-dialog.android-style .notification-footer .notification-button {
  border-left: 1px solid #E1E1E1;
  border-right: 0 !important;
}
html[dir=rtl] .notification-dialog.android-style .notification-footer .notification-button:last-child,
body.rtl-mode .notification-dialog.android-style .notification-footer .notification-button:last-child {
  border-left: 0;
}
html[dir=rtl] .notification-dialog.android-style .notification-footer .notification-button .icon,
html[dir=rtl] .notification-dialog.android-style .notification-footer .notification-button ion-icon,
body.rtl-mode .notification-dialog.android-style .notification-footer .notification-button .icon,
body.rtl-mode .notification-dialog.android-style .notification-footer .notification-button ion-icon {
  margin-right: 0;
  margin-left: 8px;
}
html[dir=rtl] .notification-dialog.ios-style .notification-header .imaged,
body.rtl-mode .notification-dialog.ios-style .notification-header .imaged {
  margin-right: 0;
  margin-left: 8px;
}
html[dir=rtl] .notification-dialog.ios-style .notification-header span,
body.rtl-mode .notification-dialog.ios-style .notification-header span {
  margin-left: 6px;
  margin-right: 0;
}
html[dir=rtl] .notification-dialog.ios-style .notification-content .in,
body.rtl-mode .notification-dialog.ios-style .notification-content .in {
  padding-right: 0;
  padding-left: 16px;
}
html[dir=rtl] .notification-dialog.ios-style .notification-footer .notification-button,
body.rtl-mode .notification-dialog.ios-style .notification-footer .notification-button {
  border-right: 0;
  border-left: 1px solid rgba(255, 255, 255, 0.1);
}
html[dir=rtl] .notification-dialog.ios-style .notification-footer .notification-button:last-child,
body.rtl-mode .notification-dialog.ios-style .notification-footer .notification-button:last-child {
  border-left: 0;
}
html[dir=rtl] .notification-dialog.ios-style .notification-footer .notification-button .icon,
html[dir=rtl] .notification-dialog.ios-style .notification-footer .notification-button ion-icon,
body.rtl-mode .notification-dialog.ios-style .notification-footer .notification-button .icon,
body.rtl-mode .notification-dialog.ios-style .notification-footer .notification-button ion-icon {
  margin-right: 0;
  margin-left: 8px;
}
html[dir=rtl] .searchbox .input-icon,
body.rtl-mode .searchbox .input-icon {
  left: auto;
  right: 0;
}
html[dir=rtl] .searchbox .form-control,
body.rtl-mode .searchbox .form-control {
  padding: 0 36px 0 16px;
}
html[dir=rtl] .nav-tabs.capsuled,
html[dir=rtl] .nav-tabs.lined,
body.rtl-mode .nav-tabs.capsuled,
body.rtl-mode .nav-tabs.lined {
  padding: 0;
  margin: 0;
}
html[dir=rtl] .timeline:before,
body.rtl-mode .timeline:before {
  left: auto;
  right: 0;
}
html[dir=rtl] .timeline .content,
body.rtl-mode .timeline .content {
  padding-left: 0;
  padding-right: 20px;
}
html[dir=rtl] .timeline .content .text,
body.rtl-mode .timeline .content .text {
  padding-right: 0;
  padding-left: 30px;
}
html[dir=rtl] .timeline .dot,
body.rtl-mode .timeline .dot {
  left: auto;
  right: -5px;
}
html[dir=rtl] .timeline.timed,
body.rtl-mode .timeline.timed {
  padding-left: 0;
  padding-right: 80px;
}
html[dir=rtl] .timeline.timed:before,
body.rtl-mode .timeline.timed:before {
  right: 80px;
}
html[dir=rtl] .timeline.timed .time,
body.rtl-mode .timeline.timed .time {
  left: auto;
  right: -80px;
  text-align: left;
  padding-right: 4px;
}
html[dir=rtl] .toast-box .in,
body.rtl-mode .toast-box .in {
  padding-right: 0;
  padding-left: 20px;
}
html[dir=rtl] .toast-box .in .icon,
html[dir=rtl] .toast-box .in ion-icon,
body.rtl-mode .toast-box .in .icon,
body.rtl-mode .toast-box .in ion-icon {
  margin-right: 0;
  margin-left: 8px;
}
html[dir=rtl] .toast-box.toast-center .in,
body.rtl-mode .toast-box.toast-center .in {
  padding-left: 0;
}
html[dir=rtl] .form-switch .form-check-label:before,
body.rtl-mode .form-switch .form-check-label:before {
  left: 4px;
  top: 3px;
  right: auto;
}
html[dir=rtl] .panelbox-left .link-listview > li a,
html[dir=rtl] .panelbox-right .link-listview > li a,
body.rtl-mode .panelbox-left .link-listview > li a,
body.rtl-mode .panelbox-right .link-listview > li a {
  padding: 10px 16px 10px 36px;
}
html[dir=rtl] .panelbox-left .image-listview > li a.item,
html[dir=rtl] .panelbox-right .image-listview > li a.item,
body.rtl-mode .panelbox-left .image-listview > li a.item,
body.rtl-mode .panelbox-right .image-listview > li a.item {
  padding-right: 16px;
  padding-left: 36px;
}
html[dir=rtl] .text-end,
body.rtl-mode .text-end {
  text-align: left !important;
}
html[dir=rtl] .text-start,
body.rtl-mode .text-start {
  text-align: right !important;
}
html[dir=rtl] #sidebarPanel .profileBox,
body.rtl-mode #sidebarPanel .profileBox {
  left: auto;
  right: 0;
}
html[dir=rtl] #sidebarPanel .profileBox:before,
body.rtl-mode #sidebarPanel .profileBox:before {
  left: auto;
  right: 0;
}
html[dir=rtl] #sidebarPanel .profileBox .image-wrapper,
body.rtl-mode #sidebarPanel .profileBox .image-wrapper {
  margin-right: 0;
  margin-left: 16px;
}
html[dir=rtl] #sidebarPanel .profileBox .in,
body.rtl-mode #sidebarPanel .profileBox .in {
  padding-right: 0;
  padding-left: 25px;
}
html[dir=rtl] #sidebarPanel .profileBox .close-sidebar-button,
body.rtl-mode #sidebarPanel .profileBox .close-sidebar-button {
  right: auto;
  left: 10px;
}
html[dir=rtl] .image-listview .multi-level > ul > li a,
html[dir=rtl] .image-listview .multi-level > ul > li .item,
html[dir=rtl] .multi-level > ul > li a,
html[dir=rtl] .multi-level > ul > li .item,
body.rtl-mode .image-listview .multi-level > ul > li a,
body.rtl-mode .image-listview .multi-level > ul > li .item,
body.rtl-mode .multi-level > ul > li a,
body.rtl-mode .multi-level > ul > li .item {
  padding-left: 36px !important;
}
html[dir=rtl] .comment-block .item .avatar,
body.rtl-mode .comment-block .item .avatar {
  margin-right: 0;
  margin-left: 14px;
}
html[dir=rtl] .comment-block .item .comment-header .title,
body.rtl-mode .comment-block .item .comment-header .title {
  padding-right: 0;
  padding-left: 10px;
}
html[dir=rtl] .comment-block .item .comment-footer .comment-button,
body.rtl-mode .comment-block .item .comment-footer .comment-button {
  margin-right: 0;
  margin-left: 14px;
}
html[dir=rtl] .comment-block .item .comment-footer .comment-button i.bi,
html[dir=rtl] .comment-block .item .comment-footer .comment-button i.icon,
html[dir=rtl] .comment-block .item .comment-footer .comment-button ion-icon,
body.rtl-mode .comment-block .item .comment-footer .comment-button i.bi,
body.rtl-mode .comment-block .item .comment-footer .comment-button i.icon,
body.rtl-mode .comment-block .item .comment-footer .comment-button ion-icon {
  margin-left: 5px;
  margin-right: 0;
}
html[dir=rtl] .stepper .stepper-button,
body.rtl-mode .stepper .stepper-button {
  border-radius: 0;
}
html[dir=rtl] .stepper-outline-primary .stepper-button:first-child,
body.rtl-mode .stepper-outline-primary .stepper-button:first-child {
  border-right: 2px solid #2E2481;
  border-left: 0;
  border-radius: 0 24px 24px 0;
}
html[dir=rtl] .stepper-outline-primary .stepper-button:last-child,
body.rtl-mode .stepper-outline-primary .stepper-button:last-child {
  border-left: 2px solid #2E2481;
  border-right: 0;
  border-radius: 24px 0 0 24px;
}
html[dir=rtl] .stepper-outline-secondary .stepper-button:first-child,
body.rtl-mode .stepper-outline-secondary .stepper-button:first-child {
  border-right: 2px solid #53AAC6;
  border-left: 0;
  border-radius: 0 24px 24px 0;
}
html[dir=rtl] .stepper-outline-secondary .stepper-button:last-child,
body.rtl-mode .stepper-outline-secondary .stepper-button:last-child {
  border-left: 2px solid #53AAC6;
  border-right: 0;
  border-radius: 24px 0 0 24px;
}
html[dir=rtl] .stepper-outline-danger .stepper-button:first-child,
body.rtl-mode .stepper-outline-danger .stepper-button:first-child {
  border-right: 2px solid #FB9393;
  border-left: 0;
  border-radius: 0 24px 24px 0;
}
html[dir=rtl] .stepper-outline-danger .stepper-button:last-child,
body.rtl-mode .stepper-outline-danger .stepper-button:last-child {
  border-left: 2px solid #FB9393;
  border-right: 0;
  border-radius: 24px 0 0 24px;
}
html[dir=rtl] .stepper-outline-success .stepper-button:first-child,
body.rtl-mode .stepper-outline-success .stepper-button:first-child {
  border-right: 2px solid #C7FB93;
  border-left: 0;
  border-radius: 0 24px 24px 0;
}
html[dir=rtl] .stepper-outline-success .stepper-button:last-child,
body.rtl-mode .stepper-outline-success .stepper-button:last-child {
  border-left: 2px solid #C7FB93;
  border-right: 0;
  border-radius: 24px 0 0 24px;
}
html[dir=rtl] .stepper-outline-warning .stepper-button:first-child,
body.rtl-mode .stepper-outline-warning .stepper-button:first-child {
  border-right: 2px solid #FBC593;
  border-left: 0;
  border-radius: 0 24px 24px 0;
}
html[dir=rtl] .stepper-outline-warning .stepper-button:last-child,
body.rtl-mode .stepper-outline-warning .stepper-button:last-child {
  border-left: 2px solid #FBC593;
  border-right: 0;
  border-radius: 24px 0 0 24px;
}
html[dir=rtl] .stepper-outline-info .stepper-button:first-child,
body.rtl-mode .stepper-outline-info .stepper-button:first-child {
  border-right: 2px solid #ffffff;
  border-left: 0;
  border-radius: 0 24px 24px 0;
}
html[dir=rtl] .stepper-outline-info .stepper-button:last-child,
body.rtl-mode .stepper-outline-info .stepper-button:last-child {
  border-left: 2px solid #ffffff;
  border-right: 0;
  border-radius: 24px 0 0 24px;
}
html[dir=rtl] .stepper-outline-dark .stepper-button:first-child,
body.rtl-mode .stepper-outline-dark .stepper-button:first-child {
  border-right: 2px solid #333;
  border-left: 0;
  border-radius: 0 24px 24px 0;
}
html[dir=rtl] .stepper-outline-dark .stepper-button:last-child,
body.rtl-mode .stepper-outline-dark .stepper-button:last-child {
  border-left: 2px solid #333;
  border-right: 0;
  border-radius: 24px 0 0 24px;
}
html[dir=rtl] #search .searchbox .close,
body.rtl-mode #search .searchbox .close {
  left: 8px;
  right: auto !important;
}
html[dir=rtl] .profile-head .avatar,
body.rtl-mode .profile-head .avatar {
  margin-left: 16px;
  margin-right: 0;
}
html[dir=rtl] .profile-stats,
body.rtl-mode .profile-stats {
  padding-right: 16px !important;
}
html[dir=rtl] .rate-block i.bi,
html[dir=rtl] .rate-block ion-icon,
html[dir=rtl] .rate-block i.icon,
body.rtl-mode .rate-block i.bi,
body.rtl-mode .rate-block ion-icon,
body.rtl-mode .rate-block i.icon {
  margin-right: 0;
  margin-left: 3px;
}
html[dir=rtl] .cart-item .in .text,
body.rtl-mode .cart-item .in .text {
  margin-left: 0;
  margin-right: 16px;
}
html[dir=rtl] .invoice .invoice-person .invoice-to,
html[dir=rtl] .invoice .invoice-person .i,
body.rtl-mode .invoice .invoice-person .invoice-to,
body.rtl-mode .invoice .invoice-person .i {
  padding-left: 12px;
  padding-right: 0;
}
html[dir=rtl] .invoice .invoice-person .invoice-from,
body.rtl-mode .invoice .invoice-person .invoice-from {
  padding-right: 12px;
  padding-left: 0;
}
html[dir=rtl] .story-block .splide__slide,
body.rtl-mode .story-block .splide__slide {
  padding-right: 0 !important;
  margin-right: 0 !important;
  padding-left: 26px !important;
  margin-left: -10px !important;
}
html[dir=rtl] .form-group.boxed .form-control.form-select,
html[dir=rtl] .form-group.basic .form-control.form-select,
body.rtl-mode .form-group.boxed .form-control.form-select,
body.rtl-mode .form-group.basic .form-control.form-select {
  background-position: left center !important;
}
html[dir=rtl] .form-group.boxed .form-control.form-select,
body.rtl-mode .form-group.boxed .form-control.form-select {
  background-position: left 12px center !important;
}

body.dark-mode-active {
  background: #ffffff !important;
  color: #ffffff;
}
body.dark-mode-active.bg-light, body.dark-mode-active.bg-white {
  background: #ffffff !important;
}
body.dark-mode-active #loader {
  background: #ffffff;
}
body.dark-mode-active select option {
  background: #ffffff;
  color: #fff;
}
body.dark-mode-active .text-muted {
  color: #586d7f !important;
}
body.dark-mode-active .bg-dark {
  background: #000 !important;
}
body.dark-mode-active .bg-light {
  background: #fff !important;
}
body.dark-mode-active h1,
body.dark-mode-active h2,
body.dark-mode-active h3,
body.dark-mode-active h4,
body.dark-mode-active h5,
body.dark-mode-active h6 {
  color: #ffffff;
}
body.dark-mode-active h1 small,
body.dark-mode-active h2 small,
body.dark-mode-active h3 small,
body.dark-mode-active h4 small,
body.dark-mode-active h5 small,
body.dark-mode-active h6 small {
  color: #ffffff;
}
body.dark-mode-active .lead {
  color: #586d7f !important;
}
body.dark-mode-active .appHeader {
  background: #ffffff;
  border-bottom-color: #1B283B;
}
body.dark-mode-active .appHeader .pageTitle {
  color: #ffffff;
}
body.dark-mode-active .appHeader.transparent {
  background: transparent !important;
}
body.dark-mode-active .appHeader.bg-light .left .headerButton,
body.dark-mode-active .appHeader.bg-light .right .headerButton {
  color: #1c1b1b;
}
body.dark-mode-active .appHeader.bg-light .pageTitle {
  color: #1c1b1b;
}
body.dark-mode-active .appHeader .left .headerButton,
body.dark-mode-active .appHeader .right .headerButton {
  color: #ffffff;
}
body.dark-mode-active .extraHeader {
  background: #ffffff;
  border-bottom-color: #1B283B;
}
body.dark-mode-active .appHeader.scrolled {
  background: transparent;
  border-bottom-color: transparent;
}
body.dark-mode-active .appHeader.scrolled.is-active {
  background: #ffffff;
  border-bottom-color: #1B283B;
}
body.dark-mode-active .section-title {
  color: #ffffff;
}
body.dark-mode-active .section .wide-block {
  background: #ffffff;
  border-top-color: #1B283B;
  border-bottom-color: #1B283B;
}
body.dark-mode-active .section .content-header,
body.dark-mode-active .section .content-footer {
  color: #586d7f;
}
body.dark-mode-active .section.inset .wide-block {
  border-color: #1B283B;
}
body.dark-mode-active .header-large-title .title {
  color: #ffffff;
}
body.dark-mode-active .header-large-title .subtitle {
  color: #ffffff !important;
}
body.dark-mode-active .appBottomMenu {
  background: #ffffff;
  border-top-color: #1B283B;
}
body.dark-mode-active .appBottomMenu .item i.bi,
body.dark-mode-active .appBottomMenu .item i.icon,
body.dark-mode-active .appBottomMenu .item ion-icon,
body.dark-mode-active .appBottomMenu .item strong {
  color: #ffffff;
}
body.dark-mode-active .appBottomMenu .item:hover i.bi,
body.dark-mode-active .appBottomMenu .item:hover i.icon,
body.dark-mode-active .appBottomMenu .item:hover ion-icon,
body.dark-mode-active .appBottomMenu .item:hover strong {
  color: #ffffff;
}
body.dark-mode-active .appBottomMenu.bg-light .item i.bi,
body.dark-mode-active .appBottomMenu.bg-light .item i.icon,
body.dark-mode-active .appBottomMenu.bg-light .item ion-icon,
body.dark-mode-active .appBottomMenu.bg-light .item strong {
  color: #1c1b1b;
}
body.dark-mode-active .appBottomMenu.bg-light .item:hover i.bi,
body.dark-mode-active .appBottomMenu.bg-light .item:hover i.icon,
body.dark-mode-active .appBottomMenu.bg-light .item:hover ion-icon,
body.dark-mode-active .appBottomMenu.bg-light .item:hover strong {
  color: #1c1b1b;
}
body.dark-mode-active .accordion {
  border-top-color: #1B283B;
  border-bottom-color: #1B283B;
  background: #ffffff !important;
}
body.dark-mode-active .accordion .accordion-body {
  background: #ffffff;
}
body.dark-mode-active .accordion .accordion-header .btn,
body.dark-mode-active .accordion .accordion-header .accordion-button {
  color: #ffffff;
  background: #ffffff !important;
}
body.dark-mode-active .accordion .accordion-header .btn:active, body.dark-mode-active .accordion .accordion-header .btn:hover,
body.dark-mode-active .accordion .accordion-header .accordion-button:active,
body.dark-mode-active .accordion .accordion-header .accordion-button:hover {
  background-color: #ffffff !important;
}
body.dark-mode-active .accordion .accordion-header .btn:after,
body.dark-mode-active .accordion .accordion-header .accordion-button:after {
  color: #586d7f;
}
body.dark-mode-active .accordion .accordion-header .btn.collapsed:before,
body.dark-mode-active .accordion .accordion-header .accordion-button.collapsed:before {
  background: #1B283B !important;
}
body.dark-mode-active .inset .accordion {
  border-color: #1B283B;
}
body.dark-mode-active .action-sheet .offcanvas-header {
  border-bottom-color: #1B283B;
}
body.dark-mode-active .action-sheet .offcanvas-header .close-button {
  color: #586d7f;
}
body.dark-mode-active .action-sheet .offcanvas-header .offcanvas-title {
  color: #ffffff;
}
body.dark-mode-active .ios-add-to-home .action-sheet-content,
body.dark-mode-active .android-add-to-home .action-sheet-content {
  color: #ffffff;
}
body.dark-mode-active .ios-add-to-home:before,
body.dark-mode-active .android-add-to-home:before {
  border-top-color: #ffffff;
}
body.dark-mode-active .action-button-list > li .btn {
  color: #ffffff;
}
body.dark-mode-active .action-button-list > li .btn:active, body.dark-mode-active .action-button-list > li .btn.active {
  background: rgba(27, 40, 59, 0.3) !important;
}
body.dark-mode-active .action-button-list .action-divider {
  background: #1B283B;
}
body.dark-mode-active .listview.transparent {
  background: transparent !important;
}
body.dark-mode-active .listview-title {
  color: #ffffff;
}
body.dark-mode-active .listview-title .link {
  color: #586d7f;
}
body.dark-mode-active .listview-title.sticky-title {
  background: #ffffff;
  box-shadow: 0 1px 0 #1B283B, 0 -1px 0 #1B283B;
}
body.dark-mode-active .listview-title.sticky-title strong {
  color: #ffffff;
}
body.dark-mode-active .listview-title.sticky-title .text-small {
  color: #586d7f;
}
body.dark-mode-active .listview {
  color: #ffffff;
  background-color: #ffffff !important;
  border-top-color: #1B283B;
  border-bottom-color: #1B283B;
}
body.dark-mode-active .listview .text-muted {
  color: #586d7f !important;
}
body.dark-mode-active .listview > li:after {
  background: #1B283B;
}
body.dark-mode-active .listview > li header,
body.dark-mode-active .listview > li footer {
  color: #ffffff;
}
body.dark-mode-active .listview > li.divider-title {
  background: rgba(0, 0, 0, 0.1);
  color: #ffffff;
  border-top-color: #1B283B;
  border-bottom-color: #1B283B;
}
body.dark-mode-active .link-listview > li a {
  color: #ffffff !important;
}
body.dark-mode-active .link-listview > li a:after {
  background-image: url("data:image/svg+xml,%0A%3Csvg width='10px' height='16px' viewBox='0 0 10 16' version='1.1' xmlns='http://www.w3.org/2000/svg' xmlns:xlink='http://www.w3.org/1999/xlink'%3E%3Cg id='Page-1' stroke='none' stroke-width='1' fill='none' fill-rule='evenodd' stroke-linecap='round' stroke-linejoin='round'%3E%3Cg id='Listview' transform='translate(-112.000000, -120.000000)' stroke='%23586d7f' stroke-width='2.178'%3E%3Cpolyline id='Path' points='114 122 120 128 114 134'%3E%3C/polyline%3E%3C/g%3E%3C/g%3E%3C/svg%3E");
}
body.dark-mode-active .link-listview > li a:active {
  background: rgba(27, 40, 59, 0.3);
}
body.dark-mode-active .image-listview > li a.item {
  color: #ffffff !important;
}
body.dark-mode-active .image-listview > li a.item:active {
  background: rgba(27, 40, 59, 0.3);
}
body.dark-mode-active .image-listview > li a.item:after {
  background-image: url("data:image/svg+xml,%0A%3Csvg width='10px' height='16px' viewBox='0 0 10 16' version='1.1' xmlns='http://www.w3.org/2000/svg' xmlns:xlink='http://www.w3.org/1999/xlink'%3E%3Cg id='Page-1' stroke='none' stroke-width='1' fill='none' fill-rule='evenodd' stroke-linecap='round' stroke-linejoin='round'%3E%3Cg id='Listview' transform='translate(-112.000000, -120.000000)' stroke='%23586d7f' stroke-width='2.178'%3E%3Cpolyline id='Path' points='114 122 120 128 114 134'%3E%3C/polyline%3E%3C/g%3E%3C/g%3E%3C/svg%3E");
}
body.dark-mode-active .image-listview.media > li {
  border-bottom: 1px solid #1B283B;
}
body.dark-mode-active .btn-light {
  background: #fff !important;
  color: #000 !important;
  border-color: #fff !important;
}
body.dark-mode-active .btn-light:hover, body.dark-mode-active .btn-light:active {
  background: #fff !important;
  color: #000 !important;
  border-color: #fff !important;
  opacity: 0.8;
}
body.dark-mode-active .btn-dark {
  background: #000 !important;
  color: #fff !important;
  border-color: #000 !important;
}
body.dark-mode-active .btn-dark:hover, body.dark-mode-active .btn-dark:active {
  background: #000 !important;
  color: #fff !important;
  border-color: #000 !important;
  opacity: 0.6;
}
body.dark-mode-active .btn-outline-light {
  border-color: #fff !important;
  color: #fff !important;
}
body.dark-mode-active .btn-outline-light:hover, body.dark-mode-active .btn-outline-light:active {
  color: #fff !important;
  border-color: #fff !important;
}
body.dark-mode-active .btn-outline-dark {
  border-color: #000 !important;
  color: #000 !important;
}
body.dark-mode-active .btn-outline-dark:hover, body.dark-mode-active .btn-outline-dark:active {
  color: #000 !important;
  border-color: #000 !important;
  background: rgba(0, 0, 0, 0.2) !important;
}
body.dark-mode-active .card {
  background: #ffffff;
}
body.dark-mode-active .card .card-title {
  color: #ffffff;
}
body.dark-mode-active .card .card-subtitle {
  color: #ffffff;
}
body.dark-mode-active .card .card-header {
  border-bottom-color: rgba(255, 255, 255, 0.1);
  color: #ffffff;
}
body.dark-mode-active .card .card-footer {
  border-top-color: rgba(255, 255, 255, 0.1);
  color: #ffffff;
}
body.dark-mode-active .card .text-muted {
  color: #586d7f !important;
}
body.dark-mode-active .card.bg-light {
  color: #4F5050;
}
body.dark-mode-active .card.bg-light .card-title {
  color: #1c1b1b;
}
body.dark-mode-active .card.bg-light .card-subtitle {
  color: #1c1b1b;
}
body.dark-mode-active .card.bg-light .card-header {
  color: #000;
  border-bottom-color: #E1E1E1;
}
body.dark-mode-active .blockquote-footer {
  color: #ffffff;
}
body.dark-mode-active .custom-control .custom-control-label {
  color: #ffffff;
}
body.dark-mode-active .custom-control .custom-control-label:before {
  background: transparent;
  border-color: rgba(255, 255, 255, 0.15) !important;
}
body.dark-mode-active .custom-control .custom-control-label:active:before {
  background: transparent !important;
  border-color: #1B283B !important;
}
body.dark-mode-active .input-list .custom-control:after {
  background: #1B283B;
}
body.dark-mode-active .input-list .custom-control-label:active {
  background: rgba(27, 40, 59, 0.3);
}
body.dark-mode-active .form-check .form-check-label {
  color: #ffffff;
}
body.dark-mode-active .form-check .form-check-label:after {
  border-color: #23344c;
}
body.dark-mode-active .input-list .form-check:after {
  background: #1B283B;
}
body.dark-mode-active .input-list .form-check .form-check-label:active {
  background: rgba(27, 40, 59, 0.3);
}
body.dark-mode-active .form-switch .form-check-label:after {
  background: #fafafa;
}
body.dark-mode-active .form-switch .form-check-label:before {
  background: #ffffff;
}
body.dark-mode-active .form-switch .form-check-input:checked ~ .form-check-label:after {
  background-color: #2E2481;
  border-color: #2E2481 !important;
}
body.dark-mode-active .form-switch .form-check-input:checked ~ .form-check-label:before {
  opacity: 1;
}
body.dark-mode-active .chip {
  background: #1B283B;
  color: #ffffff;
}
body.dark-mode-active .chip.chip-outline {
  box-shadow: inset 0 0 0 1px #1B283B;
  background: transparent;
}
body.dark-mode-active .chip .chip-icon {
  background: #ffffff;
  color: #fff;
}
body.dark-mode-active .chip .chip-delete {
  color: #ffffff;
}
body.dark-mode-active .comment-block .item .text {
  color: #ffffff;
}
body.dark-mode-active .comment-block .item .comment-header .title {
  color: #ffffff;
}
body.dark-mode-active .comment-block .item .comment-header .time {
  color: #586d7f;
}
body.dark-mode-active .comment-block .item .comment-footer .comment-button {
  color: #ffffff !important;
}
body.dark-mode-active .dialogbox .modal-dialog .modal-content {
  background: #ffffff;
}
body.dark-mode-active .dialogbox .modal-dialog .modal-content .btn-list .btn {
  border-bottom-color: #1B283B !important;
}
body.dark-mode-active .dialogbox .modal-dialog .modal-content .btn-list .btn:hover, body.dark-mode-active .dialogbox .modal-dialog .modal-content .btn-list .btn:focus, body.dark-mode-active .dialogbox .modal-dialog .modal-content .btn-list .btn:active, body.dark-mode-active .dialogbox .modal-dialog .modal-content .btn-list .btn.active {
  background: rgba(27, 40, 59, 0.3) !important;
}
body.dark-mode-active .dialogbox .modal-dialog .modal-content .btn-inline {
  background: #1B283B;
}
body.dark-mode-active .dialogbox .modal-dialog .modal-content .btn-inline .btn {
  background: #ffffff;
  color: #ffffff;
  border-right-color: #1B283B !important;
}
body.dark-mode-active .dialogbox .modal-dialog .modal-content .btn-inline .btn:hover, body.dark-mode-active .dialogbox .modal-dialog .modal-content .btn-inline .btn:focus, body.dark-mode-active .dialogbox .modal-dialog .modal-content .btn-inline .btn:active, body.dark-mode-active .dialogbox .modal-dialog .modal-content .btn-inline .btn.active {
  background: rgba(255, 255, 255, 0.7) !important;
}
body.dark-mode-active .dialogbox .modal-dialog .modal-content .modal-header .modal-title {
  color: #ffffff;
}
body.dark-mode-active .dialogbox .modal-dialog .modal-content .modal-footer {
  border-top-color: #1B283B;
}
body.dark-mode-active .divider {
  background: #1B283B;
}
body.dark-mode-active .divider .icon-box {
  background: #1B283B;
}
body.dark-mode-active .dropdown .dropdown-menu,
body.dark-mode-active .dropup .dropdown-menu {
  background: #ffffff;
  border: 1px solid #1B283B;
}
body.dark-mode-active .dropdown .dropdown-menu .dropdown-item,
body.dark-mode-active .dropup .dropdown-menu .dropdown-item {
  color: #ffffff;
}
body.dark-mode-active .dropdown .dropdown-menu .dropdown-item:hover, body.dark-mode-active .dropdown .dropdown-menu .dropdown-item:active,
body.dark-mode-active .dropup .dropdown-menu .dropdown-item:hover,
body.dark-mode-active .dropup .dropdown-menu .dropdown-item:active {
  background: rgba(27, 40, 59, 0.5) !important;
  color: #ffffff;
}
body.dark-mode-active .dropdown .dropdown-menu .dropdown-divider,
body.dark-mode-active .dropup .dropdown-menu .dropdown-divider {
  border-top-color: #1B283B !important;
}
body.dark-mode-active .dropdown .dropdown-menu .dropdown-header,
body.dark-mode-active .dropup .dropdown-menu .dropdown-header {
  color: #ffffff;
}
body.dark-mode-active .dropdown .dropdown-menu .text,
body.dark-mode-active .dropup .dropdown-menu .text {
  color: #ffffff;
}
body.dark-mode-active .dropdown .dropdown-menu i.bi,
body.dark-mode-active .dropdown .dropdown-menu i.icon,
body.dark-mode-active .dropdown .dropdown-menu ion-icon,
body.dark-mode-active .dropup .dropdown-menu i.bi,
body.dark-mode-active .dropup .dropdown-menu i.icon,
body.dark-mode-active .dropup .dropdown-menu ion-icon {
  color: #ffffff;
}
body.dark-mode-active .error-page .title {
  color: #ffffff;
}
body.dark-mode-active .fixed-footer {
  background: #ffffff;
}
body.dark-mode-active .fab-button .dropdown-menu {
  background: transparent;
  border-color: transparent;
}
body.dark-mode-active .form-wizard-section:before {
  background: #1B283B;
}
body.dark-mode-active .form-wizard-section .button-item strong {
  background: #1B283B;
  color: #586d7f;
}
body.dark-mode-active .form-wizard-section .button-item p {
  color: #586d7f;
}
body.dark-mode-active .form-wizard-section .button-item.active strong {
  background: #2E2481;
  color: #fff;
}
body.dark-mode-active .form-wizard-section .button-item.active p {
  color: #ffffff;
}
body.dark-mode-active .exampleBox {
  border-color: #1B283B;
  background: rgba(27, 40, 59, 0.3);
}
body.dark-mode-active .form-group .form-label {
  color: #ffffff;
}
body.dark-mode-active .form-group .input-info {
  color: #586d7f;
}
body.dark-mode-active .form-group .clear-input {
  color: #586d7f;
}
body.dark-mode-active .form-group.basic .form-control,
body.dark-mode-active .form-group.basic .custom-select {
  border-bottom-color: #1B283B;
  color: #ffffff;
}
body.dark-mode-active .form-group.boxed .form-control,
body.dark-mode-active .form-group.boxed .custom-select {
  color: #ffffff;
  background: #1B283B;
  border-color: #1B283B;
}
body.dark-mode-active .input-group .input-group-text {
  border-bottom-color: #1B283B;
  color: #ffffff;
}
body.dark-mode-active .form-button-group {
  background: #ffffff;
}
body.dark-mode-active .message-divider {
  color: #ffffff;
}
body.dark-mode-active .message-item .bubble {
  background: #1B283B;
  color: #ffffff;
}
body.dark-mode-active .message-item .title {
  color: #ffffff;
}
body.dark-mode-active .message-item .footer {
  color: #ffffff;
}
body.dark-mode-active .message-item.user .bubble {
  background: #2E2481;
}
body.dark-mode-active .chatFooter {
  background: #ffffff;
  border-top-color: #1B283B;
}
body.dark-mode-active .modalbox {
  background: #ffffff;
}
body.dark-mode-active .modalbox .modal-dialog .modal-content {
  background: #ffffff;
}
body.dark-mode-active .modalbox .modal-dialog .modal-content .modal-header {
  border-bottom-color: #1B283B;
  background: #ffffff;
}
body.dark-mode-active .modalbox .modal-dialog .modal-content .modal-header .modal-title {
  color: #ffffff;
}
body.dark-mode-active .notification-box {
  position: fixed;
  left: 0;
  top: -100%;
  right: 0;
  width: 100%;
  z-index: 9999;
  transition: 0.3s all;
}
body.dark-mode-active .notification-box.show {
  top: 0;
}
body.dark-mode-active .notification-dialog.android-style {
  background: whitesmoke;
}
body.dark-mode-active .notification-dialog.android-style .notification-header .in strong {
  color: #ffffff;
}
body.dark-mode-active .notification-dialog.android-style .notification-header .close-button {
  color: #586d7f;
}
body.dark-mode-active .notification-dialog.android-style .notification-header .close-button:hover, body.dark-mode-active .notification-dialog.android-style .notification-header .close-button:active {
  color: #ffffff;
}
body.dark-mode-active .notification-dialog.android-style .icon-box {
  color: #586d7f;
}
body.dark-mode-active .notification-dialog.android-style .notification-footer {
  border-top: 1px solid #1B283B;
}
body.dark-mode-active .notification-dialog.android-style .notification-footer .notification-button {
  border-right: 1px solid #1B283B;
}
body.dark-mode-active .notification-dialog.android-style .notification-footer .notification-button:last-child {
  border-right: 0;
}
body.dark-mode-active .notification-dialog.android-style .notification-footer .notification-button:hover, body.dark-mode-active .notification-dialog.android-style .notification-footer .notification-button:active {
  background: rgba(27, 40, 59, 0.3);
}
body.dark-mode-active .notification-dialog.ios-style {
  background: whitesmoke;
}
body.dark-mode-active .notification-dialog.ios-style .icon-box {
  color: #586d7f;
}
body.dark-mode-active .panelbox .modal-dialog .modal-content {
  background: #ffffff;
}
body.dark-mode-active .panelbox .modal-dialog .modal-content .modal-header .modal-title {
  color: #ffffff;
}
body.dark-mode-active .offcanvas {
  background: #ffffff;
}
body.dark-mode-active .pagination.pagination-secondary .page-item .page-link {
  background: #ffffff;
  color: #ffffff;
}
body.dark-mode-active .progress {
  background: white;
}
body.dark-mode-active .searchbox .form-control {
  border-color: #1B283B !important;
  color: #ffffff;
  background: #1B283B;
}
body.dark-mode-active .searchbox .form-control:focus {
  border-color: #2b405e !important;
}
body.dark-mode-active .searchbox .form-control:focus ~ .input-icon {
  color: #ffffff;
}
body.dark-mode-active .searchbox .close {
  color: #586d7f;
}
body.dark-mode-active .searchbox .input-icon {
  color: #586d7f;
}
body.dark-mode-active #search {
  background: #ffffff;
  border-bottom-color: #ffffff;
}
body.dark-mode-active #search .searchbox .form-control {
  color: #ffffff;
}
body.dark-mode-active #search .searchbox .form-control:focus {
  border-color: #030407;
}
body.dark-mode-active #search .searchbox .form-control:focus ~ .input-icon {
  color: #ffffff;
}
body.dark-mode-active #search .searchbox .input-icon {
  color: #586d7f;
}
body.dark-mode-active .table {
  color: #ffffff;
}
body.dark-mode-active .table tr {
  border-color: #1B283B;
}
body.dark-mode-active .table thead th {
  color: #ffffff;
}
body.dark-mode-active .table td,
body.dark-mode-active .table th {
  border-top-color: rgba(255, 255, 255, 0.08);
}
body.dark-mode-active .table-striped > tbody > tr:nth-of-type(odd) {
  background: rgba(27, 40, 59, 0.5) !important;
  color: #ffffff;
}
body.dark-mode-active .table-bordered td,
body.dark-mode-active .table-bordered th {
  border-color: #1B283B;
}
body.dark-mode-active .table.bg-primary,
body.dark-mode-active .table.bg-secondary,
body.dark-mode-active .table.bg-success,
body.dark-mode-active .table.bg-danger,
body.dark-mode-active .table.bg-warning,
body.dark-mode-active .table.bg-info {
  color: rgba(255, 255, 255, 0.7);
}
body.dark-mode-active .timeline:before {
  background: #1B283B;
}
body.dark-mode-active .timeline .dot {
  background: #586d7f;
  box-shadow: 0 0 0 4px #ffffff;
}
body.dark-mode-active .toast-box {
  background: #f2f2f2;
}
body.dark-mode-active .appFooter {
  border-top-color: #1B283B;
  background: #ffffff;
}
body.dark-mode-active .appFooter .footer-title {
  color: #ffffff;
}
body.dark-mode-active .appFooter .btn-icon {
  color: #586d7f;
}
body.dark-mode-active .sidebar-buttons {
  background: #ffffff;
  border-top: 1px solid #1B283B;
}
body.dark-mode-active .sidebar-buttons .button {
  color: #ffffff;
}
body.dark-mode-active .sidebar-buttons .button:hover, body.dark-mode-active .sidebar-buttons .button:active {
  background: rgba(27, 40, 59, 0.2);
}
body.dark-mode-active .sidebar-buttons:last-child {
  border-right-color: transparent;
}
body.dark-mode-active .profileBox .in strong {
  color: #fff;
}
body.dark-mode-active .profileBox .in .text-muted {
  color: rgba(255, 255, 255, 0.5) !important;
}
body.dark-mode-active .close-sidebar-button {
  color: rgba(255, 255, 255, 0.5) !important;
}
body.dark-mode-active .close-sidebar-button:active {
  background: rgba(27, 40, 59, 0.3);
}
body.dark-mode-active .demoIcons {
  color: #ffffff;
}
body.dark-mode-active .custom-file-upload label {
  background-color: rgba(27, 40, 59, 0.2);
  border-color: #1B283B;
}
body.dark-mode-active .custom-file-upload label span {
  color: #586d7f;
}
body.dark-mode-active .custom-file-upload label span i.bi,
body.dark-mode-active .custom-file-upload label span i.icon,
body.dark-mode-active .custom-file-upload label span ion-icon {
  color: #586d7f;
}
body.dark-mode-active .custom-file-upload label.file-uploaded span {
  color: #ffffff;
  background-color: #1B283B;
}
body.dark-mode-active .nav-tabs.capsuled {
  background: rgba(27, 40, 59, 0.4);
}
body.dark-mode-active .nav-tabs.capsuled .nav-item .nav-link {
  color: #ffffff;
}
body.dark-mode-active .nav-tabs.capsuled .nav-item .nav-link.active {
  background: #23344c;
  color: #ffffff;
}
body.dark-mode-active .nav-tabs.lined .nav-item .nav-link {
  color: #ffffff;
  background: transparent;
}
body.dark-mode-active .nav-tabs.lined .nav-item .nav-link.active {
  background: transparent;
  color: #2E2481;
}
body.dark-mode-active .blog-post .post-header {
  color: #586d7f;
  border-top-color: #1B283B;
  border-bottom-color: #1B283B;
}
body.dark-mode-active .blog-post .post-header a {
  color: #ffffff;
}
body.dark-mode-active #countDown {
  color: #ffffff;
}
body.dark-mode-active #countDown > div {
  border-color: #1B283B;
}
body.dark-mode-active #countDown > div span {
  color: #586d7f;
}
body.dark-mode-active figure.codebox {
  background: #1B283B;
}
body.dark-mode-active figure.codebox code {
  color: #ffffff;
}
body.dark-mode-active .profile-head .in .subtext {
  color: #586d7f;
}
body.dark-mode-active .profile-info .bio {
  color: #ffffff;
}
body.dark-mode-active .profile-stats .item {
  color: #ffffff;
}
body.dark-mode-active .profile-stats .item strong {
  color: #ffffff;
}
body.dark-mode-active .rate-block {
  color: #586d7f;
}
body.dark-mode-active .product-detail-header .title {
  color: #ffffff;
}
body.dark-mode-active .product-detail-header .text {
  color: #ffffff;
}
body.dark-mode-active .product-detail-header .detail-footer .price .old-price {
  color: #ffffff;
}
body.dark-mode-active .cart-item .in .text .detail {
  color: #586d7f;
}
body.dark-mode-active .cart-item .cart-item-footer {
  border-top: 1px solid #1B283B;
}
body.dark-mode-active .invoice {
  color: #4F5050;
}
body.dark-mode-active .invoice .invoice-total .listview {
  border-color: #E1E1E1;
}
body.dark-mode-active .invoice .invoice-total .listview li {
  color: #1c1b1b;
}
body.dark-mode-active .invoice .invoice-total .listview li:after {
  background: #E1E1E1;
}
body.dark-mode-active .story-block .splide__slide img {
  box-shadow: 0 0 0 3px #ffffff, 0 0 0 5px #2E2481;
}
body.dark-mode-active .story-block .seen img {
  box-shadow: 0 0 0 4px #ffffff, 0 0 0 5px rgba(88, 109, 127, 0.5);
}
body.dark-mode-active .story-block .passive img {
  box-shadow: 0 0 0 4px #ffffff, 0 0 0 5px rgba(88, 109, 127, 0.5);
}
body.dark-mode-active .cookies-modal {
  background: white;
  border-color: white;
}
body.dark-mode-active.rtl-mode .notification-dialog.android-style .notification-footer .notification-button {
  border-left-color: #1B283B;
}

/*# sourceMappingURL=style.cs.map */
