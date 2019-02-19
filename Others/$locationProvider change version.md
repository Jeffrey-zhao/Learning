1.when you change your angular version to v1.6.0 or above ,the ngRoute maybe not execute well.
 so you should add below.
 $locationProvider.hasPrefex(''); in $routeProvider config .
 there  is the detailed infomation (https://docs.angularjs.org/guide/migration#commit-aa077e8)
