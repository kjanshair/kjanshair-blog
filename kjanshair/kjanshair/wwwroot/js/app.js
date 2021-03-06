﻿var app = angular.module('app', []);

app.controller('AppController', function ($scope) {
    $scope.posts = [
        {
            title: 'Docker in Container Linux on Microsoft Azure',
            date: new Date('April 15, 2017'),
            url: '/cloud/coreosdocker',
            span: 'Last Updated:',
            id: '29'
        },
        {
            title: 'Webpack Hot Module Replacement with ASP.NET Core and Typescript',
            date: new Date('February 9, 2017'),
            url: '/blog/webpackhmrts',
            span: 'Last Updated:',
            id: '28'
        },
        {
            title: 'Azure Virtual Machines in a Nutshell',
            date: new Date('January 24, 2017'),
            url: '/cloud/armvms',
            span: 'Last Updated:',
            id: '27'
        },
        {
            title: 'Persistence Docker storage with Docker Volumes',
            date: new Date('December 24, 2016'),
            url: '/docker/dockervolumes',
            span: 'Last Updated:',
            id: '26'
        },
        {
            title: 'ASP.NET Core and SQL Server in Linux Docker Containers',
            date: new Date('December 20, 2016'),
            url: '/docker/aspnetcoresqlserver',
            span: 'Last Updated:',
            id: '25'
        },
        {
            title: 'Fun with Docker Compose',
            date: new Date('November 9, 2016'),
            url: '/docker/dockercompose',
            span: 'Last Updated:',
            id: '24'
        },
        {
            title: 'Overview of Azure Resource Manager',
            date: new Date('October 31, 2016'),
            url: '/cloud/arm/',
            span: 'Last Updated:',
            id: '23'
        },
        {
            title: 'Docker in Production (Microsoft Azure)',
            date: new Date('September 26, 2016'),
            url: '/docker/dockeronazure/',
            span: 'Last Updated:',
            icon: '',
            id: '22'
        },
        {
            title: 'Dockerize your first ASP.NET Core application',
            date: new Date('September 14, 2016'),
            url: '/docker/dockerizeaspnetcore/',
            span: 'Last Updated:',
            id: '21'
        },
        {
            title: 'Easy CSS with LESS and SASS',
            date: new Date('September 14, 2016'),
            span: 'Last Updated:',
            url: '/web/less_sass/',
            id: '20'
        },
        {
            title: 'Introduction to Microservices',
            date: new Date('September 13, 2016'),
            url: '/docker/microservices/',
            span: 'Last Updated:',
            id: '18'
        },
        {
            title: 'View Components in ASP.NET Core',
            date: new Date('September 13, 2016'),
            span: 'Last Updated:',
            url: '/web/viewcomponents/',
            id: '17'
        },
        {
            title: 'Introduction to Docker',
            date: new Date('September 13, 2016'),
            url: '/docker/introtodocker/',
            span: 'Last Updated:',
            id: '16'
        },
        {
            title: 'Basic Authentication and Authorization with ASP.NET Identity',
            date: new Date('September 13, 2016'),
            span: 'Last Updated:',
            url: '/web/identity/',
            id: '15'
        },
        {
            title: 'Introduction to .NET Core',
            date: new Date('September 13, 2016'),
            url: '/fundamentals/dotnetcore/',
            span: 'Last Updated:',
            id: '14'
        },
        {
            title: 'Grunt Task Runner',
            date: new Date('July 7, 2016'),
            span: 'Last Updated:',
            url: '/web/grunt/',
            id: '13'
        },
        {
            title: 'Entity Framework Core 1.0',
            date: new Date('August 9, 2016'),
            span: 'Last Updated:',
            url: '/web/efcore/',
            id: '12'
        },
        {
            title: 'Dependency Injection in ASP.NET Core',
            date: new Date('July 11, 2016'),
            span: 'Last Updated:',
            url: '/web/di/',
            id: '11'
        },
        {
            title: 'ASP.NET Core Logging',
            date: new Date('July 11, 2016'),
            span: 'Last Updated:',
            url: '/web/logging/',
            id: '10'
        },
        {
            title: 'Creating a simple ASP.NET Core Yeoman Generator',
            date: new Date('July 7, 2016'),
            span: 'Last Updated:',
            url: '/web/yeoman/',
            id: '9'
        },
        {
            title: 'Creating a smallest ASP.NET Core 1.0 MVC application',
            date: new Date('September 13, 2016'),
            url: '/fundamentals/smallaspnetcoreapp/',
            span: 'Last Updated:',
            id: '8'
        },
        {
            title: 'Getting Started with Angular 2.0',
            date: new Date('July 7, 2016'),
            span: 'Last Updated:',
            url: '/web/angular/',
            id: '7'
        },
        {
            title: 'ASP.NET Core 1.0 Project Structure',
            date: new Date('July 7, 2016'),
            span: 'Last Updated:',
            url: '/web/projectstructure/',
            id: '6'
        },
        {
            title: 'Getting Ready for ASP.NET Core 1.0',
            date: new Date('July 6, 2016'),
            url: '/blog/aspnetcoresystem/',
            span: 'Last Updated:',
            icon: '',
            id: '1'
        },

    ];

    $scope.clicked = function (url) {
        window.location = url;
    }
});