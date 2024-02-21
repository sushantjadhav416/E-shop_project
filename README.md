# E-shop_project
This is an  E Commerce Web Application Developed in ASP.NET MVC  with CI-CD Jenkins pipline and Github actions CI-CD workflow.

This is Two teir ASP.NET MVC based web application containerize using Docker and continously Deployed on AKS Using Argo cd Gitops Tool. 

Note. Dot NET dependencies are handled using the .csproj at the root directory of the repository.

## Application setup 
This is a MVC architecture based application where View returns a page with title and message attributes to the view.

- Execute the application locally and access it using your browser Checkout the repo and move to the directory

- git clone https://github.com/sushantjadhav416/E-shop_project

- cd E_shop.

- Execute the Docker build command to build docker image and use this application as container.
  
- You can find Kubernetes deployment .Yaml files in Deploymentfiles folder.

## Continous Integration of Two teir Application .
1. Using jenkins:
- Configure a jenkins server and Install required Plugins.
- Plugins: Docker,git,github
- Setup credentials of docker registry and add github Token.
- Create Pipline in jenkins and configure jenkinsfile path and Build the pipline.

## Continous Deployment Of Two Teir application.


## Technology Stack
- User Interface: HTML ,CSS,JS, bootstarp
- Database Connectivity: Entity Framework
- Database Management System: MSSQL SERVER
- Programming Language: c# .NET

  
