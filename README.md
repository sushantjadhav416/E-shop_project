# E-shop_project
This is an  E Commerce Web Application Developed in ASP.NET MVC  with CI-CD Jenkins pipline and Github actions CI-CD workflow.

This is Two teir ASP.NET MVC based web application containerize using Docker and continously Deployed on AKS Using Argo cd Gitops Tool.

### Screenshot
![Alt text](roject1_e-shop.png)

**Note:**  Dot NET dependencies are handled using the .csproj at the root directory of the repository.

# Prerequisites:
- Dot NET application hosted on the GitHub repo.
- Jenkins server
- Kubernetes cluster
- Argo CD
- GitHub Actions

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

2. Using GitHub Actions:
- Created .Net Build workflow  and Docker Build and push workflow.
- At the time off push event happens on this repo the workflow is get triggerd.

## Continous Deployment Of Two Teir application
- In this project we are using GitOps tool Argo CD for continous deployment on AKS.
- For that first Configure a AKS on AZURE  using Terraform like IAC tool.
- After that , Configuration Argo CD on your target node of AKS.
  follow this article for that https://argo-cd.readthedocs.io/en/stable/
- After configuration sync your application with your Github repository .
 
## Technology Stack
- User Interface: HTML ,CSS,JS, bootstarp
- Database Connectivity: Entity Framework
- Container Registry : Docker
- Cloud : Azure 
- Database Management System: MSSQL SERVER
- Programming Language: C# .NET

  
