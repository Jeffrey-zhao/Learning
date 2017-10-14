step by step how to simply install nvm
1.uninstall node already installed if you installed nodejs by install package.
  a.cd /usr/local 
  b.then /bin/node,/lib/node_modules/npm delete relative files
  command:
  npm ls -g --depth=0 #查看已经安装在全局的模块，以便删除这些全局模块后再按照不同的 node 版本重新进行全局安装
  sudo rm -rf /usr/local/lib/node_modules #删除全局 node_modules 目录
  sudo rm /usr/local/bin/node #删除 node
  cd  /usr/local/bin && ls -l | grep "../lib/node_modules/" | awk '{print $9}'| xargs rm #删除全局 node 模块注册的软链
2.nvm install.
  curl -o- https://raw.githubusercontent.com/creationix/nvm/v0.33.2/install.sh | bash
3.config nvm env.
  command: export NVM_DIR="$HOME/.nvm"[ -s "$NVM_DIR/nvm.sh" ] && . "$NVM_DIR/nvm.sh"
tips: the command above will show when you execute step 2.
      a.if your net speed is fast.ignore this below.
      1) change step 3 config.also you can save it in a file ".bash_profile".
         command : export NVM_DIR="$HOME/.nvm [ -s "$NVM_DIR/nvm.sh" ] && . "$NVM_DIR/nvm.sh"
      2) how to add a config file
        a. cd a root path
           cd ~
        b. create a config file
           touch .bash_profile 
        c. edit a config file
           open -e .bash_profile
        d.update/reload the added config file
           source .bash_profile
        e.test nvm 
           nvm -v
