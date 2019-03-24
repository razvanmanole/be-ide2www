This folder contains all the necessary resources to automate Azure resource creation and deployment for ide2www workshop. 

In order to run the .\deploy powershell script, you first need to make sure you have Azure Powershell SDK which you can find here: 
https://github.com/Azure/azure-powershell/releases/download/v5.1.1-December2017/azure-powershell.5.1.1.msi

Make sure to restart your PC before you continue. Yeah, i know, it sucks.

The .\deploy.ps1 script will take the template.json file, populate it with the variable values found in parameters.json and execute it using the Azure Powershell commands.


The scripts requires a couple of parameters:

subscriptionId - Your Azure subscription. You can find it here: https://portal.azure.com/#blade/Microsoft_Azure_Billing/SubscriptionsBlade

resourceGroupName - consider this a 'tag' under which all af your resources will be created. It's just a logical way of organizing your resources. For the sake of this workshop should be something like 'ide2www'.

resourceGroupLocation - the server geo location where your resources will be deployed to. For the sake of this workshop use 'West Europe'

deploymentName - the name of your deployment. Can be anything that will make you identify a particular deployment.  For the sake of this workshop should be something like 'powershell-deployment'



TL;DR
just run this in PowerShell and provide the Azure username and password when prompted to do so
.\deploy.ps1 '14eed544-7460-4951-9293-22e5b58f8f99' 'ide2www' 'West Europe' 'powershell-deployment'