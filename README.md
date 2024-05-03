# E-shop_project
This is an  E Commerce Web Application Developed in ASP.NET MVC And Continuously integrated using Jenkins CI pipline and Github actions CI workflows.

This is Two teir ASP.NET MVC based web application containerize using Docker and continously Deployed on AKS Using Argo cd Gitops Tool.

**Note:**  Dot NET dependencies are handled using the .csproj at the root directory of the repository.

# Prerequisites:
- Dot NET application hosted on the GitHub repo.
- Jenkins server
- Kubernetes cluster
- Argo CD
- GitHub Actions

## Application setup 


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
- Code quality analysis workflow uisng CodeQL. 
- At the time off push event happens on this repo the workflow is get triggerd.

## Continous Deployment Of Two Teir application
- In this project i am  using Argo CD GitOps tool for continous deployment on AKS.
- For that first Configure a AKS on AZURE  using ARM templates, using Shell script , Terraform like IAC tool. I have provided the Aks creation and configuration scripts in Create AKs folder.
- After that , Configuration Argo CD on your target node of AKS.
  follow this article for that https://argo-cd.readthedocs.io/en/stable/
- After configuration create new application in argocd .
- Provide a correct application details like github repo url and correct Deployment yaml file folder path, becuase ArgoCd syncs the changes made in targeted repository path.
 
## Technology Stack
- User Interface: HTML, CSS, JS, bootstarp.
- Database Connectivity: Entity Framework.
- Container Registry : Docker Hub.
- Cloud : Azure.
- Database Management System: MSSQL SERVER.
- Programming Language: C# .NET

  
