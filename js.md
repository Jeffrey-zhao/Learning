1.about javascript function
  函数是运行在定义它们的作用域中（上述例子中的foo内部的作用域），而不是运行此函数的作用域中
  function foo(){
    var a = 10;
    return function(){
        a *= 2;
        return a;       
    };   
}
var f = foo();
f(); //return 20.
f(); //return 40.
http://www.cnblogs.com/moltboy/archive/2013/04/24/3040213.html
