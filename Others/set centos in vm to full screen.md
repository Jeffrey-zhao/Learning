1. if you use Hyper-V create centos ,when it occurs not full screen ,please do like this below:
   1. get root permission :su -
   2. press cmd:  grubby --update-kernel=ALL --args=“video=hyperv_fb:1920x1080”
