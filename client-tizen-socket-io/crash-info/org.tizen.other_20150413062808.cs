S/W Version Information
Model: Mobile-RD-PQ
Tizen-Version: 2.3.0
Build-Number: Tizen-2.3.0_Mobile-RD-PQ_20150311.1610
Build-Date: 2015.03.11 16:10:43

Crash Information
Process Name: other
PID: 4710
Date: 2015-04-13 06:28:08+0900
Executable File Path: /opt/usr/apps/org.tizen.other/bin/other
Signal: 11
      (SIGSEGV)
      si_code: 2
      invalid permissions for mapped object
      si_addr = 0xb3eb0250

Register Information
r0   = 0xb0730000, r1   = 0xb3eaf250
r2   = 0x00000400, r3   = 0xb3eb0250
r4   = 0x00000010, r5   = 0xb3eaf250
r6   = 0xb0730000, r7   = 0x00000070
r8   = 0x00000400, r9   = 0xb3eaf250
r10  = 0x00000100, fp   = 0x00000070
ip   = 0x00000000, sp   = 0xbec657d8
lr   = 0xb3b2d910, pc   = 0xb3b2daf8
cpsr = 0x20000010

Memory Information
MemTotal:   797840 KB
MemFree:    361180 KB
Buffers:     66424 KB
Cached:     148924 KB
VmPeak:     137320 KB
VmSize:     119056 KB
VmLck:           0 KB
VmHWM:       15284 KB
VmRSS:       15284 KB
VmData:      63080 KB
VmStk:         136 KB
VmExe:          24 KB
VmLib:       25068 KB
VmPTE:          76 KB
VmSwap:          0 KB

Threads Information
Threads: 8
PID = 4710 TID = 4710
4710 4714 4715 4716 4717 4718 4719 4720 

Maps Information
b1794000 b1795000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
b17d2000 b17d3000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b17db000 b17e2000 r-xp /usr/lib/libfeedback.so.0.1.4
b17f5000 b17f6000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
b17fe000 b1815000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b199b000 b19a0000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
b31e9000 b3234000 r-xp /usr/lib/libGLESv1_CM.so.1.1
b323d000 b3247000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b3250000 b32ac000 r-xp /usr/lib/evas/modules/engines/gl_x11/linux-gnueabi-armv7l-1.7.99/module.so
b3ab9000 b3abf000 r-xp /usr/lib/libUMP.so
b3ac7000 b3ace000 r-xp /usr/lib/libtbm.so.1.0.0
b3ad6000 b3adb000 r-xp /usr/lib/libcapi-media-tool.so.0.1.1
b3ae3000 b3aea000 r-xp /usr/lib/libdrm.so.2.4.0
b3af3000 b3af5000 r-xp /usr/lib/libdri2.so.0.0.0
b3afd000 b3b10000 r-xp /usr/lib/libEGL_platform.so
b3b19000 b3bf0000 r-xp /usr/lib/libMali.so
b3bfb000 b3c02000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3c0a000 b3c0f000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3c17000 b3c2e000 r-xp /usr/lib/libEGL.so.1.4
b3c37000 b3c3c000 r-xp /usr/lib/libxcb-render.so.0.0.0
b3c45000 b3c46000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b3c4f000 b3c67000 r-xp /usr/lib/libpng12.so.0.50.0
b3c6f000 b3cad000 r-xp /usr/lib/libGLESv2.so.2.0
b3cb5000 b3cb9000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b3cc2000 b3cc5000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.2
b3cce000 b3d84000 r-xp /usr/lib/libcairo.so.2.11200.14
b3d8f000 b3da5000 r-xp /usr/lib/libtts.so
b3dae000 b3dbf000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3dc7000 b3dc9000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3dd1000 b3dd9000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b3de1000 b3eb0000 r-xp /opt/usr/apps/org.tizen.other/bin/other
b3ebb000 b3ec5000 r-xp /lib/libnss_files-2.13.so
b3ed3000 b3ed5000 r-xp /opt/usr/apps/org.tizen.other/lib/libboost_system.so.1.55.0
b40de000 b40ff000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b4108000 b4125000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b412e000 b41fc000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b4213000 b4239000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b4243000 b4245000 r-xp /usr/lib/libiniparser.so.0
b424f000 b4255000 r-xp /usr/lib/libcapi-security-privilege-manager.so.0.0.3
b425e000 b4264000 r-xp /usr/lib/libappsvc.so.0.1.0
b426d000 b426f000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4278000 b427c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4284000 b4288000 r-xp /usr/lib/libogg.so.0.7.1
b4290000 b42b2000 r-xp /usr/lib/libvorbis.so.0.4.3
b42ba000 b439e000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b43b2000 b43e3000 r-xp /usr/lib/libFLAC.so.8.2.0
b43ec000 b43ee000 r-xp /usr/lib/libXau.so.6.0.0
b43f6000 b4442000 r-xp /usr/lib/libssl.so.1.0.0
b444f000 b447d000 r-xp /usr/lib/libidn.so.11.5.44
b4485000 b448f000 r-xp /usr/lib/libcares.so.2.1.0
b4497000 b44dc000 r-xp /usr/lib/libsndfile.so.1.0.25
b44ea000 b44f1000 r-xp /usr/lib/libsensord-share.so
b44f9000 b450f000 r-xp /lib/libexpat.so.1.5.2
b451d000 b4520000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b4528000 b455c000 r-xp /usr/lib/libicule.so.51.1
b4565000 b4578000 r-xp /usr/lib/libxcb.so.1.1.0
b4580000 b45bb000 r-xp /usr/lib/libcurl.so.4.3.0
b45c4000 b45cd000 r-xp /usr/lib/libethumb.so.1.7.99
b5b3b000 b5bcf000 r-xp /usr/lib/libstdc++.so.6.0.16
b5be2000 b5be4000 r-xp /usr/lib/libctxdata.so.0.0.0
b5bec000 b5bf9000 r-xp /usr/lib/libremix.so.0.0.0
b5c01000 b5c02000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b5c0a000 b5c21000 r-xp /usr/lib/liblua-5.1.so
b5c2a000 b5c31000 r-xp /usr/lib/libembryo.so.1.7.99
b5c39000 b5c5c000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c74000 b5c8a000 r-xp /usr/lib/libsensor.so.1.1.0
b5c93000 b5ce9000 r-xp /usr/lib/libpixman-1.so.0.28.2
b5cf6000 b5d19000 r-xp /usr/lib/libfontconfig.so.1.5.0
b5d22000 b5d68000 r-xp /usr/lib/libharfbuzz.so.0.907.0
b5d71000 b5d84000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d8c000 b5ddc000 r-xp /usr/lib/libfreetype.so.6.8.1
b5de7000 b5dea000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b5df2000 b5df6000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b5dfe000 b5e03000 r-xp /usr/lib/libecore_fb.so.1.7.99
b5e0c000 b5e16000 r-xp /usr/lib/libXext.so.6.4.0
b5e1e000 b5eff000 r-xp /usr/lib/libX11.so.6.3.0
b5f0a000 b5f0d000 r-xp /usr/lib/libXtst.so.6.1.0
b5f15000 b5f1b000 r-xp /usr/lib/libXrender.so.1.3.0
b5f23000 b5f28000 r-xp /usr/lib/libXrandr.so.2.2.0
b5f30000 b5f31000 r-xp /usr/lib/libXinerama.so.1.0.0
b5f3a000 b5f42000 r-xp /usr/lib/libXi.so.6.1.0
b5f43000 b5f46000 r-xp /usr/lib/libXfixes.so.3.1.0
b5f4e000 b5f50000 r-xp /usr/lib/libXgesture.so.7.0.0
b5f58000 b5f5a000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5f62000 b5f63000 r-xp /usr/lib/libXdamage.so.1.1.0
b5f6c000 b5f72000 r-xp /usr/lib/libXcursor.so.1.0.2
b5f7b000 b5f94000 r-xp /usr/lib/libecore_con.so.1.7.99
b5f9e000 b5fa4000 r-xp /usr/lib/libecore_imf.so.1.7.99
b5fac000 b5fb4000 r-xp /usr/lib/libethumb_client.so.1.7.99
b5fbc000 b5fc0000 r-xp /usr/lib/libefreet_mime.so.1.7.99
b5fc9000 b5fdf000 r-xp /usr/lib/libefreet.so.1.7.99
b5fe8000 b5ff1000 r-xp /usr/lib/libedbus.so.1.7.99
b5ff9000 b60de000 r-xp /usr/lib/libicuuc.so.51.1
b60f3000 b6232000 r-xp /usr/lib/libicui18n.so.51.1
b6242000 b629e000 r-xp /usr/lib/libedje.so.1.7.99
b62a8000 b62b9000 r-xp /usr/lib/libecore_input.so.1.7.99
b62c1000 b62c6000 r-xp /usr/lib/libecore_file.so.1.7.99
b62ce000 b62e7000 r-xp /usr/lib/libeet.so.1.7.99
b62f8000 b62fc000 r-xp /usr/lib/libappcore-common.so.1.1
b6305000 b63d1000 r-xp /usr/lib/libevas.so.1.7.99
b63f6000 b6417000 r-xp /usr/lib/libecore_evas.so.1.7.99
b6420000 b644f000 r-xp /usr/lib/libecore_x.so.1.7.99
b6459000 b658d000 r-xp /usr/lib/libelementary.so.1.7.99
b65a5000 b65a6000 r-xp /usr/lib/libjournal.so.0.1.0
b65af000 b667a000 r-xp /usr/lib/libxml2.so.2.7.8
b6688000 b6698000 r-xp /lib/libresolv-2.13.so
b669c000 b66b2000 r-xp /lib/libz.so.1.2.5
b66ba000 b66bc000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b66c4000 b66c9000 r-xp /usr/lib/libffi.so.5.0.10
b66d2000 b66d3000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b66db000 b66de000 r-xp /lib/libattr.so.1.1.0
b66e6000 b688e000 r-xp /usr/lib/libcrypto.so.1.0.0
b68ae000 b68c8000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b68d1000 b693a000 r-xp /lib/libm-2.13.so
b6943000 b6983000 r-xp /usr/lib/libeina.so.1.7.99
b698c000 b6994000 r-xp /usr/lib/libvconf.so.0.2.45
b699c000 b699f000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b69a7000 b69db000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b69e4000 b6ab8000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b6ac4000 b6aca000 r-xp /lib/librt-2.13.so
b6ad3000 b6ad8000 r-xp /usr/lib/libcapi-base-common.so.0.1.7
b6ae1000 b6ae8000 r-xp /lib/libcrypt-2.13.so
b6b18000 b6b1b000 r-xp /lib/libcap.so.2.21
b6b23000 b6b25000 r-xp /usr/lib/libiri.so
b6b2d000 b6b4c000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6b54000 b6b6a000 r-xp /usr/lib/libecore.so.1.7.99
b6b80000 b6b85000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6b8e000 b6c5e000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6c5f000 b6c6d000 r-xp /usr/lib/libail.so.0.1.0
b6c75000 b6c8c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c95000 b6c9f000 r-xp /lib/libunwind.so.8.0.1
b6ccd000 b6de8000 r-xp /lib/libc-2.13.so
b6df6000 b6dfe000 r-xp /lib/libgcc_s-4.6.4.so.1
b6e06000 b6e30000 r-xp /usr/lib/libdbus-1.so.3.7.2
b6e39000 b6e3c000 r-xp /usr/lib/libbundle.so.0.1.22
b6e44000 b6e46000 r-xp /lib/libdl-2.13.so
b6e4f000 b6e52000 r-xp /usr/lib/libsmack.so.1.0.0
b6e5a000 b6ebc000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6ec6000 b6ed8000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6ee1000 b6ef5000 r-xp /lib/libpthread-2.13.so
b6f02000 b6f06000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f10000 b6f12000 r-xp /usr/lib/libdlog.so.0.0.0
b6f1a000 b6f25000 r-xp /usr/lib/libaul.so.0.1.0
b6f2f000 b6f33000 r-xp /usr/lib/libsys-assert.so
b6f3c000 b6f59000 r-xp /lib/ld-2.13.so
b6f62000 b6f68000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
b6f70000 b6f9c000 rw-p [heap]
b6f9c000 b71bf000 rw-p [heap]
bec46000 bec67000 rwxp [stack]
End of Maps Information

Callstack Information (PID:4710)
Call Stack Count: 1
 0: (0xb3b2daf8) [/usr/lib/libMali.so] + 0x14af8
End of Call Stack

Package Information
Package Name: org.tizen.other
Package ID : org.tizen.other
Version: 1.0.0
Package Type: coretpk
App Name: other
App ID: org.tizen.other
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
_##
04-13 06:27:51.715+0900 D/LAUNCH  ( 4654): launchpad.c: __real_launch(229) > [SECURE_LOG] [/opt/usr/apps/org.tizen.other/bin/other:Platform:launchpad:done]
04-13 06:27:51.745+0900 I/CAPI_APPFW_APPLICATION( 4654): app_main.c: ui_app_main(697) > app_efl_main
04-13 06:27:51.745+0900 D/LAUNCH  ( 4654): appcore-efl.c: appcore_efl_main(1569) > [other:Application:main:done]
04-13 06:27:51.790+0900 D/AUL_PAD ( 2204): sigchild.h: __signal_block_sigchld(230) > SIGCHLD blocked
04-13 06:27:51.790+0900 D/AUL_PAD ( 2204): sigchild.h: __send_app_launch_signal(112) > send launch signal done
04-13 06:27:51.790+0900 D/AUL_PAD ( 2204): sigchild.h: __signal_unblock_sigchld(242) > SIGCHLD unblocked
04-13 06:27:51.790+0900 D/AUL     ( 2170): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
04-13 06:27:51.790+0900 E/AUL     ( 2170): simple_util.c: __trm_app_info_send_socket(264) > access
04-13 06:27:51.790+0900 D/RESOURCED( 2372): proc-noti.c: recv_str(87) > [recv_str,87] str is null
04-13 06:27:51.790+0900 D/RESOURCED( 2372): proc-noti.c: process_message(169) > [process_message,169] process message caller pid 2170
04-13 06:27:51.790+0900 D/RESOURCED( 2372): proc-main.c: resourced_proc_action(669) > [SECURE_LOG] [resourced_proc_action,669] appid org.tizen.other, pid 4654, type 4 
04-13 06:27:51.790+0900 D/AUL_AMD ( 2170): amd_main.c: __add_item_running_list(170) > [SECURE_LOG] __add_item_running_list pid: 4654
04-13 06:27:51.790+0900 D/AUL_AMD ( 2170): amd_main.c: __add_item_running_list(183) > [SECURE_LOG] __add_item_running_list appid: org.tizen.other
04-13 06:27:51.790+0900 D/RESOURCED( 2372): proc-main.c: resourced_proc_status_change(570) > [SECURE_LOG] [resourced_proc_status_change,570] launch request org.tizen.other, 4654
04-13 06:27:51.790+0900 D/RESOURCED( 2372): proc-main.c: resourced_proc_status_change(572) > [SECURE_LOG] [resourced_proc_status_change,572] launch request org.tizen.other with pkgname
04-13 06:27:51.790+0900 D/RESOURCED( 2372): net-cls-cgroup.c: make_net_cls_cgroup_with_pid(311) > [SECURE_LOG] [make_net_cls_cgroup_with_pid,311] pkg: org; pid: 4654
04-13 06:27:51.790+0900 D/RESOURCED( 2372): cgroup.c: cgroup_write_node(89) > [SECURE_LOG] [cgroup_write_node,89] cgroup_buf /sys/fs/cgroup/net_cls/org/cgroup.procs, value 4654
04-13 06:27:51.790+0900 D/RESOURCED( 2372): net-cls-cgroup.c: update_classids(249) > [update_classids,249] class id table updated
04-13 06:27:51.790+0900 D/RESOURCED( 2372): cgroup.c: cgroup_read_node(107) > [SECURE_LOG] [cgroup_read_node,107] cgroup_buf /sys/fs/cgroup/net_cls/org/net_cls.classid, value 0
04-13 06:27:51.790+0900 D/RESOURCED( 2372): datausage-common.c: create_each_iptable_rule(689) > [create_each_iptable_rule,689] Unsupported network interface type 0
04-13 06:27:51.790+0900 D/RESOURCED( 2372): datausage-common.c: create_each_iptable_rule(697) > [create_each_iptable_rule,697] Counter already exists!
04-13 06:27:51.790+0900 D/RESOURCED( 2372): datausage-common.c: create_each_iptable_rule(689) > [create_each_iptable_rule,689] Unsupported network interface type 0
04-13 06:27:51.790+0900 D/RESOURCED( 2372): datausage-common.c: create_each_iptable_rule(697) > [create_each_iptable_rule,697] Counter already exists!
04-13 06:27:51.790+0900 E/RESOURCED( 2372): proc-main.c: resourced_proc_status_change(577) > [resourced_proc_status_change,577] available memory = 526
04-13 06:27:51.790+0900 D/RESOURCED( 2372): proc-noti.c: safe_write_int(178) > [safe_write_int,178] Response is not needed
04-13 06:27:51.790+0900 D/AUL     ( 2245): launch.c: app_request_to_launchpad(295) > launch request result : 4654
04-13 06:27:51.790+0900 D/MENU_SCREEN( 2245): item.c: item_launch(1003) > Launch app's ret : [4654]
04-13 06:27:51.790+0900 D/LAUNCH  ( 2245): item.c: item_launch(1005) > [org.tizen.other:Menuscreen:launch:done]
04-13 06:27:51.790+0900 D/MENU_SCREEN( 2245): item_event.c: _item_up_cb(85) > ITEM: mouse up event callback is invoked for 0xb72084a0
04-13 06:27:51.800+0900 D/APP_CORE( 4654): appcore-efl.c: __before_loop(1017) > elm_config_preferred_engine_set is not called
04-13 06:27:51.810+0900 D/AUL     ( 4654): pkginfo.c: aul_app_get_pkgid_bypid(257) > [SECURE_LOG] appid for 4654 is org.tizen.other
04-13 06:27:51.810+0900 D/APP_CORE( 4654): appcore.c: appcore_init(532) > [SECURE_LOG] dir : /usr/apps/org.tizen.other/res/locale
04-13 06:27:51.810+0900 D/APP_CORE( 4654): appcore-i18n.c: update_region(71) > *****appcore setlocale=en_US.UTF-8
04-13 06:27:51.810+0900 D/AUL     ( 4654): app_sock.c: __create_server_sock(135) > pg path - already exists
04-13 06:27:51.810+0900 D/LAUNCH  ( 4654): appcore-efl.c: __before_loop(1035) > [other:Platform:appcore_init:done]
04-13 06:27:51.810+0900 I/CAPI_APPFW_APPLICATION( 4654): app_main.c: _ui_app_appcore_create(556) > app_appcore_create
04-13 06:27:51.975+0900 W/PROCESSMGR( 2100): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=4654
04-13 06:27:52.015+0900 D/indicator( 2218): indicator_ui.c: _property_changed_cb(1198) > _property_changed_cb[1198]	 "UNSNIFF API 1c00003"
04-13 06:27:52.020+0900 D/indicator( 2218): indicator_ui.c: _active_indicator_handle(1107) > [SECURE_LOG] _active_indicator_handle[1107]	 "Type : 1, opacity 0, active_win 2600003"
04-13 06:27:52.020+0900 D/indicator( 2218): indicator_util.c: indicator_signal_emit_by_win(142) > [SECURE_LOG] indicator_signal_emit_by_win[142]	 "emission 0 bg.opaque"
04-13 06:27:52.025+0900 D/indicator( 2218): indicator_ui.c: _active_indicator_handle(1113) > [SECURE_LOG] _active_indicator_handle[1113]	 "Type : 2, angle 0, active_win 2600003"
04-13 06:27:52.025+0900 D/indicator( 2218): indicator_ui.c: _rotate_window(644) > _rotate_window[644]	 "_rotate_window = 0"
04-13 06:27:52.025+0900 D/LAUNCH  ( 4654): appcore-efl.c: __before_loop(1045) > [other:Application:create:done]
04-13 06:27:52.025+0900 D/APP_CORE( 4654): appcore-efl.c: __check_wm_rotation_support(752) > Disable window manager rotation
04-13 06:27:52.025+0900 D/APP_CORE( 4654): appcore.c: __aul_handler(423) > [APP 4654]     AUL event: AUL_START
04-13 06:27:52.025+0900 D/APP_CORE( 4654): appcore-efl.c: __do_app(470) > [APP 4654] Event: RESET State: CREATED
04-13 06:27:52.025+0900 D/APP_CORE( 4654): appcore-efl.c: __do_app(496) > [APP 4654] RESET
04-13 06:27:52.025+0900 D/LAUNCH  ( 4654): appcore-efl.c: __do_app(498) > [other:Application:reset:start]
04-13 06:27:52.025+0900 I/CAPI_APPFW_APPLICATION( 4654): app_main.c: _ui_app_appcore_reset(638) > app_appcore_reset
04-13 06:27:52.025+0900 D/APP_SVC ( 4654): appsvc.c: __set_bundle(161) > __set_bundle
04-13 06:27:52.025+0900 F/socket.io( 4654): thread_start
04-13 06:27:52.025+0900 F/socket.io( 4654): finish 0
04-13 06:27:52.025+0900 D/LAUNCH  ( 4654): appcore-efl.c: __do_app(501) > [other:Application:reset:done]
04-13 06:27:52.040+0900 F/socket.io( 4654): Connect Start
04-13 06:27:52.040+0900 F/socket.io( 4654): Set ConnectListener
04-13 06:27:52.040+0900 F/socket.io( 4654): Set ClosetListener
04-13 06:27:52.040+0900 F/socket.io( 4654): Set FaileListener
04-13 06:27:52.040+0900 F/socket.io( 4654): Connect
04-13 06:27:52.040+0900 F/socket.io( 4654): Lock
04-13 06:27:52.040+0900 F/socket.io( 4654): !!!
04-13 06:27:52.060+0900 I/APP_CORE( 4654): appcore-efl.c: __do_app(507) > Legacy lifecycle: 0
04-13 06:27:52.060+0900 I/APP_CORE( 4654): appcore-efl.c: __do_app(509) > [APP 4654] Initial Launching, call the resume_cb
04-13 06:27:52.060+0900 I/CAPI_APPFW_APPLICATION( 4654): app_main.c: _ui_app_appcore_resume(620) > app_appcore_resume
04-13 06:27:52.060+0900 D/APP_CORE( 4654): appcore.c: __aul_handler(426) > [SECURE_LOG] caller_appid : org.tizen.menu-screen
04-13 06:27:52.065+0900 D/APP_CORE( 4654): appcore-efl.c: __show_cb(826) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2600003
04-13 06:27:52.065+0900 D/APP_CORE( 4654): appcore-efl.c: __add_win(672) > [EVENT_TEST][EVENT] __add_win WIN:2600003
04-13 06:27:52.075+0900 E/socket.io( 4654): 482: Connection failed
04-13 06:27:52.075+0900 F/socket.io( 4654): sio closed
04-13 06:27:52.190+0900 F/socket.io( 4654): return ok???????????????????
04-13 06:27:52.195+0900 D/indicator( 2218): wifi.c: indicator_wifi_change_cb(231) > indicator_wifi_change_cb[231]	 "CONNECTION WiFi Status: 2"
04-13 06:27:52.195+0900 D/indicator( 2218): indicator_util.c: indicator_signal_emit(96) > indicator_signal_emit[96]	 "SIGNAL EMIT indicator.wifi.updown.updownload"
04-13 06:27:52.420+0900 W/CRASH_MANAGER( 4665): worker.c: worker_job(1189) > 11046546f74681428874072
04-13 06:27:52.510+0900 W/PROCESSMGR( 2100): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=2245
04-13 06:27:52.530+0900 D/indicator( 2218): indicator_ui.c: _property_changed_cb(1198) > _property_changed_cb[1198]	 "UNSNIFF API 2600003"
04-13 06:27:52.535+0900 D/indicator( 2218): indicator_ui.c: _active_indicator_handle(1107) > [SECURE_LOG] _active_indicator_handle[1107]	 "Type : 1, opacity 0, active_win 1c00003"
04-13 06:27:52.540+0900 D/indicator( 2218): indicator_util.c: indicator_signal_emit_by_win(142) > [SECURE_LOG] indicator_signal_emit_by_win[142]	 "emission 0 bg.opaque"
04-13 06:27:52.540+0900 D/indicator( 2218): indicator_ui.c: _active_indicator_handle(1113) > [SECURE_LOG] _active_indicator_handle[1113]	 "Type : 2, angle 0, active_win 1c00003"
04-13 06:27:52.540+0900 D/indicator( 2218): indicator_ui.c: _rotate_window(644) > _rotate_window[644]	 "_rotate_window = 0"
04-13 06:27:52.660+0900 I/AUL_PAD ( 2204): sigchild.h: __launchpad_sig_child(142) > dead_pid = 4654 pgid = 4654
04-13 06:27:52.660+0900 I/AUL_PAD ( 2204): sigchild.h: __sigchild_action(123) > dead_pid(4654)
04-13 06:27:52.660+0900 D/AUL_PAD ( 2204): sigchild.h: __send_app_dead_signal(81) > send dead signal done
04-13 06:27:52.660+0900 I/AUL_PAD ( 2204): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
04-13 06:27:52.660+0900 I/AUL_PAD ( 2204): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
04-13 06:27:52.660+0900 I/AUL_AMD ( 2170): amd_main.c: __app_dead_handler(257) > __app_dead_handler, pid: 4654
04-13 06:27:52.660+0900 D/AUL_AMD ( 2170): amd_key.c: _unregister_key_event(156) > ===key stack===
04-13 06:27:52.660+0900 D/AUL     ( 2170): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
04-13 06:27:52.660+0900 E/AUL     ( 2170): simple_util.c: __trm_app_info_send_socket(264) > access
04-13 06:27:52.660+0900 D/STARTER ( 2225): lock-daemon-lite.c: lockd_app_dead_cb_lite(998) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.52/src/lock-daemon-lite.c:998:D] app dead cb call! (pid : 4654)
04-13 06:27:52.660+0900 D/STARTER ( 2225): menu_daemon.c: menu_daemon_check_dead_signal(621) > [menu_daemon_check_dead_signal:621] Process 4654 is termianted
04-13 06:27:52.660+0900 D/STARTER ( 2225): menu_daemon.c: menu_daemon_check_dead_signal(646) > [menu_daemon_check_dead_signal:646] Unknown process, ignore it (dead pid 4654, home pid 2245, taskmgr pid -1)
04-13 06:27:52.675+0900 D/PROCESSMGR( 2100): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(406) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x1c00003
04-13 06:27:52.790+0900 D/AUL_AMD ( 2170): amd_launch.c: __grab_timeout_handler(1199) > pid(4654) ecore_x_pointer_ungrab
04-13 06:27:52.790+0900 D/MENU_SCREEN( 2245): layout.c: layout_disable_block(126) > Disable layout blocker
04-13 06:27:52.795+0900 D/AUL_AMD ( 2170): amd_request.c: __add_history_handler(243) > [SECURE_LOG] add rua history org.tizen.other /opt/usr/apps/org.tizen.other/bin/other
04-13 06:27:52.795+0900 D/RUA     ( 2170): rua.c: rua_add_history(179) > rua_add_history start
04-13 06:27:52.815+0900 D/RUA     ( 2170): rua.c: rua_add_history(247) > rua_add_history ok
04-13 06:27:53.200+0900 D/indicator( 2218): wifi.c: indicator_wifi_change_cb(231) > indicator_wifi_change_cb[231]	 "CONNECTION WiFi Status: 2"
04-13 06:27:53.200+0900 D/indicator( 2218): indicator_util.c: indicator_signal_emit(96) > indicator_signal_emit[96]	 "SIGNAL EMIT indicator.wifi.updown.none"
04-13 06:27:55.920+0900 D/PKGMGR_INFO( 4665): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(2995) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.tizen.other/bin/other' and package_app_info.app_disable IN ('false','False')
04-13 06:27:55.920+0900 D/PKGMGR_INFO( 4665): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3001) > [SECURE_LOG] query = select DISTINCT package_app_info.app_id, package_app_info.app_component, package_app_info.app_installed_storage from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale='en-us' LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.tizen.other/bin/other' and package_app_info.app_disable IN ('false','False')
04-13 06:27:55.925+0900 D/PKGMGR_INFO( 4665): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3109) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.tizen.other/bin/other' and package_app_info.app_disable IN ('false','False')
04-13 06:27:55.925+0900 D/PKGMGR_INFO( 4665): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3115) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.tizen.other/bin/other' and package_app_info.app_disable IN ('false','False')
04-13 06:27:55.935+0900 D/PKGMGR_INFO( 4665): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3109) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.tizen.other/bin/other' and package_app_info.app_disable IN ('false','False')
04-13 06:27:55.935+0900 D/PKGMGR_INFO( 4665): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3115) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.tizen.other/bin/other' and package_app_info.app_disable IN ('false','False')
04-13 06:27:56.950+0900 D/AUL     ( 4685): launch.c: app_request_to_launchpad(281) > [SECURE_LOG] launch request : org.tizen.crash-popup
04-13 06:27:56.950+0900 D/AUL     ( 4685): app_sock.c: __app_send_raw(264) > pid(-2) : cmd(0)
04-13 06:27:56.950+0900 D/AUL_AMD ( 2170): amd_request.c: __request_handler(491) > __request_handler: 0
04-13 06:27:56.955+0900 D/AUL_AMD ( 2170): amd_request.c: __request_handler(536) > launch a single-instance appid: org.tizen.crash-popup
04-13 06:27:56.960+0900 D/AUL     ( 2170): pkginfo.c: aul_app_get_appid_bypid(205) > second change pgid = 2144, pid = 4685
04-13 06:27:56.965+0900 D/AUL_AMD ( 2170): amd_launch.c: _start_app(1466) > [SECURE_LOG] caller : (null)
04-13 06:27:56.975+0900 D/AUL_AMD ( 2170): amd_launch.c: _start_app(1770) > process_pool: false
04-13 06:27:56.975+0900 D/AUL_AMD ( 2170): amd_launch.c: _start_app(1773) > h/w acceleration: SYS
04-13 06:27:56.975+0900 D/AUL_AMD ( 2170): amd_launch.c: _start_app(1775) > [SECURE_LOG] appid: org.tizen.crash-popup
04-13 06:27:56.975+0900 D/AUL_AMD ( 2170): amd_launch.c: __set_appinfo_for_launchpad(1927) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
04-13 06:27:56.975+0900 D/AUL     ( 2170): app_sock.c: __app_send_raw(264) > pid(-1) : cmd(0)
04-13 06:27:56.975+0900 D/AUL_PAD ( 2204): launchpad.c: __launchpad_main_loop(641) > [SECURE_LOG] pkg name : org.tizen.crash-popup
04-13 06:27:56.975+0900 D/AUL_PAD ( 2204): launchpad.c: __modify_bundle(380) > parsing app_path: No arguments
04-13 06:27:56.975+0900 D/AUL_PAD ( 2204): launchpad.c: __launchpad_main_loop(699) > [SECURE_LOG] ==> real launch pid : 4686 /usr/apps/org.tizen.crash-popup/bin/crash-popup
04-13 06:27:56.975+0900 D/AUL_PAD ( 4686): launchpad.c: __launchpad_main_loop(668) > lock up test log(no error) : fork done
04-13 06:27:56.975+0900 D/AUL_PAD ( 2204): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
04-13 06:27:56.980+0900 D/AUL_PAD ( 4686): launchpad.c: __launchpad_main_loop(679) > lock up test log(no error) : prepare exec - first done
04-13 06:27:56.980+0900 D/AUL_PAD ( 4686): launchpad.c: __prepare_exec(136) > [SECURE_LOG] pkg_name : org.tizen.crash-popup / pkg_type : rpm / app_path : /usr/apps/org.tizen.crash-popup/bin/crash-popup 
04-13 06:27:57.000+0900 D/AUL_PAD ( 4686): launchpad.c: __launchpad_main_loop(693) > lock up test log(no error) : prepare exec - second done
04-13 06:27:57.000+0900 D/AUL_PAD ( 4686): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 0 : /usr/apps/org.tizen.crash-popup/bin/crash-popup##
04-13 06:27:57.000+0900 D/AUL_PAD ( 4686): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 2 : _PROCESS_NAME_##
04-13 06:27:57.000+0900 D/AUL_PAD ( 4686): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 4 : _EXEPATH_##
04-13 06:27:57.000+0900 D/AUL_PAD ( 4686): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 6 : _INTERNAL_SYSPOPUP_NAME_##
04-13 06:27:57.000+0900 D/AUL_PAD ( 4686): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 8 : __AUL_STARTTIME__##
04-13 06:27:57.000+0900 D/AUL_PAD ( 4686): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 10 : __AUL_CALLER_PID__##
04-13 06:27:57.000+0900 D/LAUNCH  ( 4686): launchpad.c: __real_launch(229) > [SECURE_LOG] [/usr/apps/org.tizen.crash-popup/bin/crash-popup:Platform:launchpad:done]
04-13 06:27:57.045+0900 D/LAUNCH  ( 4686): appcore-efl.c: appcore_efl_main(1569) > [crash-popup:Application:main:done]
04-13 06:27:57.070+0900 D/APP_CORE( 4686): appcore-efl.c: __before_loop(1017) > elm_config_preferred_engine_set is not called
04-13 06:27:57.080+0900 D/AUL_PAD ( 2204): sigchild.h: __signal_block_sigchld(230) > SIGCHLD blocked
04-13 06:27:57.080+0900 D/AUL_PAD ( 2204): sigchild.h: __send_app_launch_signal(112) > send launch signal done
04-13 06:27:57.080+0900 D/AUL_PAD ( 2204): sigchild.h: __signal_unblock_sigchld(242) > SIGCHLD unblocked
04-13 06:27:57.080+0900 D/AUL     ( 2170): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
04-13 06:27:57.080+0900 E/AUL     ( 2170): simple_util.c: __trm_app_info_send_socket(264) > access
04-13 06:27:57.080+0900 D/RESOURCED( 2372): proc-noti.c: recv_str(87) > [recv_str,87] str is null
04-13 06:27:57.080+0900 D/RESOURCED( 2372): proc-noti.c: process_message(169) > [process_message,169] process message caller pid 2170
04-13 06:27:57.080+0900 D/RESOURCED( 2372): proc-main.c: resourced_proc_action(669) > [SECURE_LOG] [resourced_proc_action,669] appid org.tizen.crash-popup, pid 4686, type 4 
04-13 06:27:57.080+0900 D/AUL_AMD ( 2170): amd_main.c: __add_item_running_list(170) > [SECURE_LOG] __add_item_running_list pid: 4686
04-13 06:27:57.080+0900 D/AUL_AMD ( 2170): amd_main.c: __add_item_running_list(183) > [SECURE_LOG] __add_item_running_list appid: org.tizen.crash-popup
04-13 06:27:57.080+0900 D/RESOURCED( 2372): proc-main.c: resourced_proc_status_change(570) > [SECURE_LOG] [resourced_proc_status_change,570] launch request org.tizen.crash-popup, 4686
04-13 06:27:57.080+0900 D/RESOURCED( 2372): proc-main.c: resourced_proc_status_change(572) > [SECURE_LOG] [resourced_proc_status_change,572] launch request org.tizen.crash-popup with pkgname
04-13 06:27:57.080+0900 D/RESOURCED( 2372): net-cls-cgroup.c: make_net_cls_cgroup_with_pid(311) > [SECURE_LOG] [make_net_cls_cgroup_with_pid,311] pkg: org; pid: 4686
04-13 06:27:57.080+0900 D/AUL     ( 4686): pkginfo.c: aul_app_get_pkgid_bypid(257) > [SECURE_LOG] appid for 4686 is org.tizen.crash-popup
04-13 06:27:57.080+0900 D/RESOURCED( 2372): cgroup.c: cgroup_write_node(89) > [SECURE_LOG] [cgroup_write_node,89] cgroup_buf /sys/fs/cgroup/net_cls/org/cgroup.procs, value 4686
04-13 06:27:57.080+0900 D/APP_CORE( 4686): appcore.c: appcore_init(532) > [SECURE_LOG] dir : /usr/apps/org.tizen.crash-popup/res/locale
04-13 06:27:57.080+0900 D/APP_CORE( 4686): appcore-i18n.c: update_region(71) > *****appcore setlocale=en_US.UTF-8
04-13 06:27:57.080+0900 D/RESOURCED( 2372): net-cls-cgroup.c: update_classids(249) > [update_classids,249] class id table updated
04-13 06:27:57.080+0900 D/RESOURCED( 2372): cgroup.c: cgroup_read_node(107) > [SECURE_LOG] [cgroup_read_node,107] cgroup_buf /sys/fs/cgroup/net_cls/org/net_cls.classid, value 0
04-13 06:27:57.080+0900 D/RESOURCED( 2372): datausage-common.c: create_each_iptable_rule(689) > [create_each_iptable_rule,689] Unsupported network interface type 0
04-13 06:27:57.080+0900 D/RESOURCED( 2372): datausage-common.c: create_each_iptable_rule(697) > [create_each_iptable_rule,697] Counter already exists!
04-13 06:27:57.080+0900 D/RESOURCED( 2372): datausage-common.c: create_each_iptable_rule(689) > [create_each_iptable_rule,689] Unsupported network interface type 0
04-13 06:27:57.080+0900 D/RESOURCED( 2372): datausage-common.c: create_each_iptable_rule(697) > [create_each_iptable_rule,697] Counter already exists!
04-13 06:27:57.080+0900 E/RESOURCED( 2372): proc-main.c: resourced_proc_status_change(577) > [resourced_proc_status_change,577] available memory = 525
04-13 06:27:57.080+0900 D/RESOURCED( 2372): proc-noti.c: safe_write_int(178) > [safe_write_int,178] Response is not needed
04-13 06:27:57.080+0900 D/AUL     ( 4685): launch.c: app_request_to_launchpad(295) > launch request result : 4686
04-13 06:27:57.080+0900 D/AUL     ( 4686): app_sock.c: __create_server_sock(135) > pg path - already exists
04-13 06:27:57.080+0900 D/LAUNCH  ( 4686): appcore-efl.c: __before_loop(1035) > [crash-popup:Platform:appcore_init:done]
04-13 06:27:57.125+0900 D/APP_CORE( 4686): appcore-i18n.c: update_region(71) > *****appcore setlocale=en_US.UTF-8
04-13 06:27:57.125+0900 D/LAUNCH  ( 4686): appcore-efl.c: __before_loop(1045) > [crash-popup:Application:create:done]
04-13 06:27:57.130+0900 D/APP_CORE( 4686): appcore-efl.c: __check_wm_rotation_support(752) > Disable window manager rotation
04-13 06:27:57.130+0900 D/APP_CORE( 4686): appcore.c: __aul_handler(423) > [APP 4686]     AUL event: AUL_START
04-13 06:27:57.130+0900 D/APP_CORE( 4686): appcore-efl.c: __do_app(470) > [APP 4686] Event: RESET State: CREATED
04-13 06:27:57.130+0900 D/APP_CORE( 4686): appcore-efl.c: __do_app(496) > [APP 4686] RESET
04-13 06:27:57.130+0900 D/LAUNCH  ( 4686): appcore-efl.c: __do_app(498) > [crash-popup:Application:reset:start]
04-13 06:27:57.160+0900 D/CRASH_POPUP( 4686): crash.c: app_reset(216) > bundle_get_val - process_name:other
04-13 06:27:57.160+0900 D/CRASH_POPUP( 4686): crash.c: app_reset(223) > bundle_get_val - exepath:/opt/usr/apps/org.tizen.other/bin/other
04-13 06:27:57.165+0900 D/PKGMGR_INFO( 4686): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(2995) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.tizen.other/bin/other' and package_app_info.app_disable IN ('false','False')
04-13 06:27:57.165+0900 D/PKGMGR_INFO( 4686): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3001) > [SECURE_LOG] query = select DISTINCT package_app_info.app_id, package_app_info.app_component, package_app_info.app_installed_storage from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale='en-us' LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.tizen.other/bin/other' and package_app_info.app_disable IN ('false','False')
04-13 06:27:57.170+0900 D/PKGMGR_INFO( 4686): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3109) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.tizen.other/bin/other' and package_app_info.app_disable IN ('false','False')
04-13 06:27:57.170+0900 D/PKGMGR_INFO( 4686): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3115) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.tizen.other/bin/other' and package_app_info.app_disable IN ('false','False')
04-13 06:27:57.180+0900 I/CRASH_POPUP( 4686): crash.c: load_crash_process_popup(117) > Popup content: other has closed unexpectedly.
04-13 06:27:57.200+0900 D/indicator( 2218): wifi.c: indicator_wifi_change_cb(231) > indicator_wifi_change_cb[231]	 "CONNECTION WiFi Status: 2"
04-13 06:27:57.200+0900 D/indicator( 2218): indicator_util.c: indicator_signal_emit(96) > indicator_signal_emit[96]	 "SIGNAL EMIT indicator.wifi.updown.updownload"
04-13 06:27:57.230+0900 W/PROCESSMGR( 2100): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=4686
04-13 06:27:57.400+0900 D/LAUNCH  ( 4686): appcore-efl.c: __do_app(501) > [crash-popup:Application:reset:done]
04-13 06:27:57.410+0900 I/APP_CORE( 4686): appcore-efl.c: __do_app(507) > Legacy lifecycle: 0
04-13 06:27:57.410+0900 I/APP_CORE( 4686): appcore-efl.c: __do_app(509) > [APP 4686] Initial Launching, call the resume_cb
04-13 06:27:57.410+0900 D/APP_CORE( 4686): appcore.c: __aul_handler(426) > [SECURE_LOG] caller_appid : (null)
04-13 06:27:57.415+0900 D/APP_CORE( 4686): appcore-efl.c: __show_cb(826) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2600006
04-13 06:27:57.415+0900 D/APP_CORE( 4686): appcore-efl.c: __add_win(672) > [EVENT_TEST][EVENT] __add_win WIN:2600006
04-13 06:27:57.465+0900 D/RESOURCED( 2372): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 4686, type = 0
04-13 06:27:57.465+0900 D/AUL_AMD ( 2170): amd_launch.c: __e17_status_handler(1888) > pid(4686) status(3)
04-13 06:27:57.465+0900 D/RESOURCED( 2372): proc-main.c: resourced_proc_status_change(555) > [SECURE_LOG] [resourced_proc_status_change,555] set foreground : 4686
04-13 06:27:57.465+0900 I/RESOURCED( 2372): lowmem-handler.c: lowmem_move_memcgroup(1185) > [lowmem_move_memcgroup,1185] buf : /sys/fs/cgroup/memory/foreground/cgroup.procs, pid : 4686, oom : 200
04-13 06:27:57.470+0900 E/RESOURCED( 2372): lowmem-handler.c: lowmem_move_memcgroup(1188) > [lowmem_move_memcgroup,1188] /sys/fs/cgroup/memory/foreground/cgroup.procs open failed
04-13 06:27:57.470+0900 E/RESOURCED( 2372): proc-main.c: proc_update_process_state(233) > [proc_update_process_state,233] Current pid (4686) didn't have any process list
04-13 06:27:57.470+0900 D/RESOURCED( 2372): cpu.c: cpu_foreground_state(92) > [cpu_foreground_state,92] cpu_foreground_state : pid = 4686, appname = (null)
04-13 06:27:57.470+0900 D/RESOURCED( 2372): cgroup.c: cgroup_write_node(89) > [SECURE_LOG] [cgroup_write_node,89] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 4686
04-13 06:27:57.470+0900 D/APP_CORE( 4686): appcore-efl.c: __update_win(718) > [EVENT_TEST][EVENT] __update_win WIN:2600006 fully_obscured 0
04-13 06:27:57.470+0900 D/APP_CORE( 4686): appcore-efl.c: __visibility_cb(884) > bvisibility 1, b_active -1
04-13 06:27:57.470+0900 D/APP_CORE( 4686): appcore-efl.c: __visibility_cb(887) >  Go to Resume state
04-13 06:27:57.470+0900 D/APP_CORE( 4686): appcore-efl.c: __do_app(470) > [APP 4686] Event: RESUME State: RUNNING
04-13 06:27:57.470+0900 D/LAUNCH  ( 4686): appcore-efl.c: __do_app(557) > [crash-popup:Application:resume:start]
04-13 06:27:57.470+0900 D/LAUNCH  ( 4686): appcore-efl.c: __do_app(567) > [crash-popup:Application:resume:done]
04-13 06:27:57.470+0900 D/LAUNCH  ( 4686): appcore-efl.c: __do_app(569) > [crash-popup:Application:Launching:done]
04-13 06:27:57.470+0900 D/APP_CORE( 4686): appcore-efl.c: __trm_app_info_send_socket(230) > __trm_app_info_send_socket
04-13 06:27:57.470+0900 E/APP_CORE( 4686): appcore-efl.c: __trm_app_info_send_socket(233) > access
04-13 06:27:57.485+0900 D/APP_CORE( 4686): appcore.c: __prt_ltime(183) > [APP 4686] first idle after reset: 537 msec
04-13 06:27:57.675+0900 D/PROCESSMGR( 2100): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(336) > [PROCESSMGR] last_pointed_win=0x60006c bd->visible=1
04-13 06:27:58.090+0900 D/AUL_AMD ( 2170): amd_request.c: __add_history_handler(243) > [SECURE_LOG] add rua history org.tizen.crash-popup /usr/apps/org.tizen.crash-popup/bin/crash-popup
04-13 06:27:58.090+0900 D/RUA     ( 2170): rua.c: rua_add_history(179) > rua_add_history start
04-13 06:27:58.195+0900 D/indicator( 2218): wifi.c: indicator_wifi_change_cb(231) > indicator_wifi_change_cb[231]	 "CONNECTION WiFi Status: 2"
04-13 06:27:58.195+0900 D/indicator( 2218): indicator_util.c: indicator_signal_emit(96) > indicator_signal_emit[96]	 "SIGNAL EMIT indicator.wifi.updown.none"
04-13 06:27:58.465+0900 D/RUA     ( 2170): rua.c: rua_add_history(247) > rua_add_history ok
04-13 06:28:00.375+0900 D/indicator( 2218): clock.c: indicator_get_apm_by_region(1016) > indicator_get_apm_by_region[1016]	 "TimeZone is Asia/Seoul"
04-13 06:28:00.380+0900 D/indicator( 2218): clock.c: indicator_get_time_by_region(1136) > indicator_get_time_by_region[1136]	 "BestPattern is HH:mm"
04-13 06:28:00.380+0900 D/indicator( 2218): clock.c: indicator_get_time_by_region(1137) > indicator_get_time_by_region[1137]	 "TimeZone is Asia/Seoul"
04-13 06:28:00.380+0900 D/indicator( 2218): clock.c: indicator_get_time_by_region(1156) > indicator_get_time_by_region[1156]	 "DATE & TIME is en_US 06:28 5 HH:mm"
04-13 06:28:00.380+0900 D/indicator( 2218): clock.c: indicator_get_time_by_region(1158) > indicator_get_time_by_region[1158]	 "24H :: Before change 06:28"
04-13 06:28:00.380+0900 D/indicator( 2218): clock.c: indicator_get_time_by_region(1160) > indicator_get_time_by_region[1160]	 "24H :: After change 06&#x2236;28"
04-13 06:28:00.380+0900 D/indicator( 2218): clock.c: indicator_clock_changed_cb(352) > indicator_clock_changed_cb[352]	 "[CLOCK MODULE] Timer Status : 366992 Time: <font_size=34>06&#x2236;28</font_size></font>"
04-13 06:28:05.475+0900 D/EFL     ( 4686): ecore_x<4686> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=270554287 button=1
04-13 06:28:05.540+0900 D/EFL     ( 4686): ecore_x<4686> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=270554355 button=1
04-13 06:28:05.540+0900 D/PROCESSMGR( 2100): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(466) > [PROCESSMGR] ev_win=0x600044  register trigger_timer!  pointed_win=0x64201b 
04-13 06:28:05.555+0900 D/AUL     ( 4686): app_sock.c: __app_send_raw_with_noreply(363) > pid(-2) : cmd(22)
04-13 06:28:05.555+0900 D/AUL_AMD ( 2170): amd_request.c: __request_handler(491) > __request_handler: 22
04-13 06:28:05.555+0900 D/APP_CORE( 4686): appcore-efl.c: __after_loop(1060) > [APP 4686] PAUSE before termination
04-13 06:28:05.580+0900 W/PROCESSMGR( 2100): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=2245
04-13 06:28:05.585+0900 D/PROCESSMGR( 2100): e_mod_processmgr.c: _e_mod_processmgr_wininfo_del(141) > [PROCESSMGR] delete anr_trigger_timer!
04-13 06:28:06.125+0900 I/AUL_PAD ( 2204): sigchild.h: __launchpad_sig_child(142) > dead_pid = 4686 pgid = 4686
04-13 06:28:06.125+0900 I/AUL_PAD ( 2204): sigchild.h: __sigchild_action(123) > dead_pid(4686)
04-13 06:28:06.125+0900 D/AUL_PAD ( 2204): sigchild.h: __send_app_dead_signal(81) > send dead signal done
04-13 06:28:06.125+0900 I/AUL_PAD ( 2204): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
04-13 06:28:06.125+0900 I/AUL_PAD ( 2204): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
04-13 06:28:06.160+0900 D/STARTER ( 2225): lock-daemon-lite.c: lockd_app_dead_cb_lite(998) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.52/src/lock-daemon-lite.c:998:D] app dead cb call! (pid : 4686)
04-13 06:28:06.160+0900 D/STARTER ( 2225): menu_daemon.c: menu_daemon_check_dead_signal(621) > [menu_daemon_check_dead_signal:621] Process 4686 is termianted
04-13 06:28:06.160+0900 I/AUL_AMD ( 2170): amd_main.c: __app_dead_handler(257) > __app_dead_handler, pid: 4686
04-13 06:28:06.160+0900 D/AUL_AMD ( 2170): amd_key.c: _unregister_key_event(156) > ===key stack===
04-13 06:28:06.160+0900 D/AUL     ( 2170): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
04-13 06:28:06.165+0900 E/AUL     ( 2170): simple_util.c: __trm_app_info_send_socket(264) > access
04-13 06:28:06.165+0900 D/STARTER ( 2225): menu_daemon.c: menu_daemon_check_dead_signal(646) > [menu_daemon_check_dead_signal:646] Unknown process, ignore it (dead pid 4686, home pid 2245, taskmgr pid -1)
04-13 06:28:07.555+0900 D/AUL_AMD ( 2170): amd_status.c: __app_terminate_timer_cb(108) > pid(4686)
04-13 06:28:07.555+0900 D/AUL_AMD ( 2170): amd_status.c: __app_terminate_timer_cb(112) > send SIGKILL: No such process
04-13 06:28:08.110+0900 D/EFL     ( 2245): ecore_x<2245> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=270556922 button=1
04-13 06:28:08.110+0900 D/MENU_SCREEN( 2245): mouse.c: _down_cb(103) > Mouse down (250,322)
04-13 06:28:08.110+0900 D/MENU_SCREEN( 2245): item_event.c: _item_down_cb(63) > ITEM: mouse down event callback is invoked for 0xb72084a0
04-13 06:28:08.230+0900 D/EFL     ( 2245): ecore_x<2245> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=270557048 button=1
04-13 06:28:08.230+0900 D/PROCESSMGR( 2100): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(466) > [PROCESSMGR] ev_win=0x600044  register trigger_timer!  pointed_win=0x60006c 
04-13 06:28:08.235+0900 D/MENU_SCREEN( 2245): mouse.c: _up_cb(120) > Mouse up (256,321)
04-13 06:28:08.235+0900 D/MENU_SCREEN( 2245): item.c: _focus_clicked_cb(668) > ITEM: mouse up event callback is invoked for 0xb72084a0
04-13 06:28:08.235+0900 D/MENU_SCREEN( 2245): layout.c: layout_enable_block(116) > Enable layout blocker
04-13 06:28:08.235+0900 D/AUL     ( 2245): launch.c: app_request_to_launchpad(281) > [SECURE_LOG] launch request : org.tizen.other
04-13 06:28:08.235+0900 D/AUL     ( 2245): app_sock.c: __app_send_raw(264) > pid(-2) : cmd(1)
04-13 06:28:08.235+0900 D/AUL_AMD ( 2170): amd_request.c: __request_handler(491) > __request_handler: 1
04-13 06:28:08.235+0900 D/AUL_AMD ( 2170): amd_request.c: __request_handler(536) > launch a single-instance appid: org.tizen.other
04-13 06:28:08.235+0900 D/AUL_AMD ( 2170): amd_launch.c: _start_app(1466) > [SECURE_LOG] caller : org.tizen.menu-screen
04-13 06:28:08.245+0900 D/AUL_AMD ( 2170): amd_launch.c: _start_app(1591) > win(c00002) ecore_x_pointer_grab(1)
04-13 06:28:08.245+0900 E/AUL_AMD ( 2170): amd_launch.c: invoke_dbus_method_sync(1177) > dbus_connection_send error(org.freedesktop.DBus.Error.ServiceUnknown:The name org.tizen.system.coord was not provided by any .service files)
04-13 06:28:08.245+0900 D/AUL_AMD ( 2170): amd_launch.c: _start_app(1675) > org.tizen.system.coord.rotation-Degree : -74
04-13 06:28:08.245+0900 D/AUL_AMD ( 2170): amd_launch.c: _start_app(1770) > process_pool: false
04-13 06:28:08.245+0900 D/AUL_AMD ( 2170): amd_launch.c: _start_app(1773) > h/w acceleration: SYS
04-13 06:28:08.245+0900 D/AUL_AMD ( 2170): amd_launch.c: _start_app(1775) > [SECURE_LOG] appid: org.tizen.other
04-13 06:28:08.245+0900 D/AUL_AMD ( 2170): amd_launch.c: __set_appinfo_for_launchpad(1927) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
04-13 06:28:08.245+0900 D/AUL     ( 2170): app_sock.c: __app_send_raw(264) > pid(-1) : cmd(1)
04-13 06:28:08.245+0900 D/AUL_PAD ( 2204): launchpad.c: __launchpad_main_loop(641) > [SECURE_LOG] pkg name : org.tizen.other
04-13 06:28:08.245+0900 D/AUL_PAD ( 2204): launchpad.c: __modify_bundle(380) > parsing app_path: No arguments
04-13 06:28:08.245+0900 D/AUL_PAD ( 2204): launchpad.c: __launchpad_main_loop(699) > [SECURE_LOG] ==> real launch pid : 4710 /opt/usr/apps/org.tizen.other/bin/other
04-13 06:28:08.245+0900 D/AUL_PAD ( 4710): launchpad.c: __launchpad_main_loop(668) > lock up test log(no error) : fork done
04-13 06:28:08.245+0900 D/AUL_PAD ( 2204): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
04-13 06:28:08.245+0900 D/AUL_PAD ( 4710): launchpad.c: __launchpad_main_loop(679) > lock up test log(no error) : prepare exec - first done
04-13 06:28:08.250+0900 D/AUL_PAD ( 4710): launchpad.c: __prepare_exec(136) > [SECURE_LOG] pkg_name : org.tizen.other / pkg_type : rpm / app_path : /opt/usr/apps/org.tizen.other/bin/other 
04-13 06:28:08.270+0900 D/AUL_PAD ( 4710): launchpad.c: __launchpad_main_loop(693) > lock up test log(no error) : prepare exec - second done
04-13 06:28:08.270+0900 D/AUL_PAD ( 4710): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.tizen.other/bin/other##
04-13 06:28:08.270+0900 D/AUL_PAD ( 4710): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
04-13 06:28:08.270+0900 D/AUL_PAD ( 4710): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
04-13 06:28:08.270+0900 D/AUL_PAD ( 4710): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 6 : __AUL_CALLER_APPID__##
04-13 06:28:08.270+0900 D/LAUNCH  ( 4710): launchpad.c: __real_launch(229) > [SECURE_LOG] [/opt/usr/apps/org.tizen.other/bin/other:Platform:launchpad:done]
04-13 06:28:08.305+0900 I/CAPI_APPFW_APPLICATION( 4710): app_main.c: ui_app_main(697) > app_efl_main
04-13 06:28:08.305+0900 D/LAUNCH  ( 4710): appcore-efl.c: appcore_efl_main(1569) > [other:Application:main:done]
04-13 06:28:08.345+0900 D/AUL_PAD ( 2204): sigchild.h: __signal_block_sigchld(230) > SIGCHLD blocked
04-13 06:28:08.345+0900 D/AUL_PAD ( 2204): sigchild.h: __send_app_launch_signal(112) > send launch signal done
04-13 06:28:08.345+0900 D/AUL_PAD ( 2204): sigchild.h: __signal_unblock_sigchld(242) > SIGCHLD unblocked
04-13 06:28:08.345+0900 D/AUL     ( 2170): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
04-13 06:28:08.345+0900 E/AUL     ( 2170): simple_util.c: __trm_app_info_send_socket(264) > access
04-13 06:28:08.345+0900 D/RESOURCED( 2372): proc-noti.c: recv_str(87) > [recv_str,87] str is null
04-13 06:28:08.345+0900 D/RESOURCED( 2372): proc-noti.c: process_message(169) > [process_message,169] process message caller pid 2170
04-13 06:28:08.345+0900 D/RESOURCED( 2372): proc-main.c: resourced_proc_action(669) > [SECURE_LOG] [resourced_proc_action,669] appid org.tizen.other, pid 4710, type 4 
04-13 06:28:08.345+0900 D/AUL_AMD ( 2170): amd_main.c: __add_item_running_list(170) > [SECURE_LOG] __add_item_running_list pid: 4710
04-13 06:28:08.350+0900 D/AUL_AMD ( 2170): amd_main.c: __add_item_running_list(183) > [SECURE_LOG] __add_item_running_list appid: org.tizen.other
04-13 06:28:08.350+0900 D/RESOURCED( 2372): proc-main.c: resourced_proc_status_change(570) > [SECURE_LOG] [resourced_proc_status_change,570] launch request org.tizen.other, 4710
04-13 06:28:08.350+0900 D/RESOURCED( 2372): proc-main.c: resourced_proc_status_change(572) > [SECURE_LOG] [resourced_proc_status_change,572] launch request org.tizen.other with pkgname
04-13 06:28:08.350+0900 D/RESOURCED( 2372): net-cls-cgroup.c: make_net_cls_cgroup_with_pid(311) > [SECURE_LOG] [make_net_cls_cgroup_with_pid,311] pkg: org; pid: 4710
04-13 06:28:08.350+0900 D/RESOURCED( 2372): cgroup.c: cgroup_write_node(89) > [SECURE_LOG] [cgroup_write_node,89] cgroup_buf /sys/fs/cgroup/net_cls/org/cgroup.procs, value 4710
04-13 06:28:08.350+0900 D/AUL     ( 2245): launch.c: app_request_to_launchpad(295) > launch request result : 4710
04-13 06:28:08.350+0900 D/MENU_SCREEN( 2245): item.c: item_launch(1003) > Launch app's ret : [4710]
04-13 06:28:08.350+0900 D/LAUNCH  ( 2245): item.c: item_launch(1005) > [org.tizen.other:Menuscreen:launch:done]
04-13 06:28:08.350+0900 D/MENU_SCREEN( 2245): item_event.c: _item_up_cb(85) > ITEM: mouse up event callback is invoked for 0xb72084a0
04-13 06:28:08.350+0900 D/RESOURCED( 2372): net-cls-cgroup.c: update_classids(249) > [update_classids,249] class id table updated
04-13 06:28:08.350+0900 D/RESOURCED( 2372): cgroup.c: cgroup_read_node(107) > [SECURE_LOG] [cgroup_read_node,107] cgroup_buf /sys/fs/cgroup/net_cls/org/net_cls.classid, value 0
04-13 06:28:08.350+0900 D/RESOURCED( 2372): datausage-common.c: create_each_iptable_rule(689) > [create_each_iptable_rule,689] Unsupported network interface type 0
04-13 06:28:08.350+0900 D/RESOURCED( 2372): datausage-common.c: create_each_iptable_rule(697) > [create_each_iptable_rule,697] Counter already exists!
04-13 06:28:08.350+0900 D/RESOURCED( 2372): datausage-common.c: create_each_iptable_rule(689) > [create_each_iptable_rule,689] Unsupported network interface type 0
04-13 06:28:08.350+0900 D/RESOURCED( 2372): datausage-common.c: create_each_iptable_rule(697) > [create_each_iptable_rule,697] Counter already exists!
04-13 06:28:08.350+0900 E/RESOURCED( 2372): proc-main.c: resourced_proc_status_change(577) > [resourced_proc_status_change,577] available memory = 526
04-13 06:28:08.350+0900 D/RESOURCED( 2372): proc-noti.c: safe_write_int(178) > [safe_write_int,178] Response is not needed
04-13 06:28:08.370+0900 D/APP_CORE( 4710): appcore-efl.c: __before_loop(1017) > elm_config_preferred_engine_set is not called
04-13 06:28:08.385+0900 D/AUL     ( 4710): pkginfo.c: aul_app_get_pkgid_bypid(257) > [SECURE_LOG] appid for 4710 is org.tizen.other
04-13 06:28:08.385+0900 D/APP_CORE( 4710): appcore.c: appcore_init(532) > [SECURE_LOG] dir : /usr/apps/org.tizen.other/res/locale
04-13 06:28:08.385+0900 D/APP_CORE( 4710): appcore-i18n.c: update_region(71) > *****appcore setlocale=en_US.UTF-8
04-13 06:28:08.385+0900 D/AUL     ( 4710): app_sock.c: __create_server_sock(135) > pg path - already exists
04-13 06:28:08.385+0900 D/LAUNCH  ( 4710): appcore-efl.c: __before_loop(1035) > [other:Platform:appcore_init:done]
04-13 06:28:08.385+0900 I/CAPI_APPFW_APPLICATION( 4710): app_main.c: _ui_app_appcore_create(556) > app_appcore_create
04-13 06:28:08.545+0900 W/PROCESSMGR( 2100): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=4710
04-13 06:28:08.585+0900 D/indicator( 2218): indicator_ui.c: _property_changed_cb(1198) > _property_changed_cb[1198]	 "UNSNIFF API 1c00003"
04-13 06:28:08.605+0900 D/indicator( 2218): indicator_ui.c: _active_indicator_handle(1107) > [SECURE_LOG] _active_indicator_handle[1107]	 "Type : 1, opacity 0, active_win 2600003"
04-13 06:28:08.605+0900 D/indicator( 2218): indicator_util.c: indicator_signal_emit_by_win(142) > [SECURE_LOG] indicator_signal_emit_by_win[142]	 "emission 0 bg.opaque"
04-13 06:28:08.610+0900 D/indicator( 2218): indicator_ui.c: _active_indicator_handle(1113) > [SECURE_LOG] _active_indicator_handle[1113]	 "Type : 2, angle 0, active_win 2600003"
04-13 06:28:08.610+0900 D/indicator( 2218): indicator_ui.c: _rotate_window(644) > _rotate_window[644]	 "_rotate_window = 0"
04-13 06:28:08.620+0900 D/LAUNCH  ( 4710): appcore-efl.c: __before_loop(1045) > [other:Application:create:done]
04-13 06:28:08.625+0900 D/APP_CORE( 4710): appcore-efl.c: __check_wm_rotation_support(752) > Disable window manager rotation
04-13 06:28:08.625+0900 D/APP_CORE( 4710): appcore.c: __aul_handler(423) > [APP 4710]     AUL event: AUL_START
04-13 06:28:08.625+0900 D/APP_CORE( 4710): appcore-efl.c: __do_app(470) > [APP 4710] Event: RESET State: CREATED
04-13 06:28:08.625+0900 D/APP_CORE( 4710): appcore-efl.c: __do_app(496) > [APP 4710] RESET
04-13 06:28:08.625+0900 D/LAUNCH  ( 4710): appcore-efl.c: __do_app(498) > [other:Application:reset:start]
04-13 06:28:08.625+0900 I/CAPI_APPFW_APPLICATION( 4710): app_main.c: _ui_app_appcore_reset(638) > app_appcore_reset
04-13 06:28:08.625+0900 D/APP_SVC ( 4710): appsvc.c: __set_bundle(161) > __set_bundle
04-13 06:28:08.625+0900 F/socket.io( 4710): thread_start
04-13 06:28:08.625+0900 F/socket.io( 4710): finish 0
04-13 06:28:08.625+0900 D/LAUNCH  ( 4710): appcore-efl.c: __do_app(501) > [other:Application:reset:done]
04-13 06:28:08.630+0900 F/socket.io( 4710): Connect Start
04-13 06:28:08.630+0900 F/socket.io( 4710): Set ConnectListener
04-13 06:28:08.630+0900 F/socket.io( 4710): Set ClosetListener
04-13 06:28:08.630+0900 F/socket.io( 4710): Set FaileListener
04-13 06:28:08.630+0900 F/socket.io( 4710): Connect
04-13 06:28:08.630+0900 F/socket.io( 4710): Lock
04-13 06:28:08.630+0900 F/socket.io( 4710): !!!
04-13 06:28:08.630+0900 I/APP_CORE( 4710): appcore-efl.c: __do_app(507) > Legacy lifecycle: 0
04-13 06:28:08.630+0900 I/APP_CORE( 4710): appcore-efl.c: __do_app(509) > [APP 4710] Initial Launching, call the resume_cb
04-13 06:28:08.630+0900 I/CAPI_APPFW_APPLICATION( 4710): app_main.c: _ui_app_appcore_resume(620) > app_appcore_resume
04-13 06:28:08.630+0900 D/APP_CORE( 4710): appcore.c: __aul_handler(426) > [SECURE_LOG] caller_appid : org.tizen.menu-screen
04-13 06:28:08.635+0900 D/APP_CORE( 4710): appcore-efl.c: __show_cb(826) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2600003
04-13 06:28:08.635+0900 D/APP_CORE( 4710): appcore-efl.c: __add_win(672) > [EVENT_TEST][EVENT] __add_win WIN:2600003
04-13 06:28:08.715+0900 E/socket.io( 4710): 566: Connected.
04-13 06:28:08.725+0900 D/sio_packet( 4710): from json
04-13 06:28:08.725+0900 D/value.IsObject()( 4710): if binary from json
04-13 06:28:08.725+0900 D/sio_packet( 4710): from json
04-13 06:28:08.725+0900 D/sio_packet( 4710): from json
04-13 06:28:08.725+0900 D/value.IsArray()( 4710): if arr from json
04-13 06:28:08.725+0900 D/sio_packet( 4710): from json
04-13 06:28:08.725+0900 D/sio_packet( 4710): IsInt64
04-13 06:28:08.725+0900 D/sio_packet( 4710): from json
04-13 06:28:08.725+0900 D/sio_packet( 4710): IsInt64
04-13 06:28:08.725+0900 E/socket.io( 4710): 554: On handshake, sid
04-13 06:28:08.730+0900 E/socket.io( 4710): 651: Received Message type(connect)
04-13 06:28:08.730+0900 E/socket.io( 4710): 489: On Connected
04-13 06:28:08.730+0900 F/socket.io( 4710): unlock
04-13 06:28:08.730+0900 F/socket.io( 4710): emit connectMessage
04-13 06:28:08.730+0900 F/sio_packet( 4710): accept()
04-13 06:28:08.730+0900 F/sio_packet( 4710): start accept_message
04-13 06:28:08.730+0900 F/sio_packet( 4710): arr, but we will use it like binary
04-13 06:28:08.730+0900 F/sio_packet( 4710): start accept_array_message()
04-13 06:28:08.730+0900 F/sio_packet( 4710): start accept_message
04-13 06:28:08.730+0900 F/sio_packet( 4710): start accept_message
04-13 06:28:08.730+0900 E/socket.io( 4710): 743: encoded paylod length: 63
04-13 06:28:08.730+0900 F/socket.io( 4710): bind connectMessage
04-13 06:28:08.730+0900 F/socket.io( 4710): emit connectMessage
04-13 06:28:08.730+0900 F/sio_packet( 4710): accept()
04-13 06:28:08.730+0900 F/sio_packet( 4710): start accept_message
04-13 06:28:08.730+0900 F/sio_packet( 4710): arr, but we will use it like binary
04-13 06:28:08.730+0900 F/sio_packet( 4710): start accept_array_message()
04-13 06:28:08.730+0900 F/sio_packet( 4710): start accept_message
04-13 06:28:08.730+0900 F/sio_packet( 4710): start accept_message
04-13 06:28:08.730+0900 E/socket.io( 4710): 743: encoded paylod length: 13
04-13 06:28:08.730+0900 F/socket.io( 4710): close 4710
04-13 06:28:08.730+0900 E/socket.io( 4710): 800: ping exit, con is expired? 0, ec: Operation canceled
04-13 06:28:08.730+0900 E/socket.io( 4710): 800: ping exit, con is expired? 0, ec: Operation canceled
04-13 06:28:08.740+0900 F/socket.io( 4710): return ok???????????????????
04-13 06:28:08.795+0900 W/CRASH_MANAGER( 4665): worker.c: worker_job(1189) > 11047106f7468142887408
