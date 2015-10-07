using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;


//"c:\Program Files (x86)\Reference Assemblies\Microsoft\WindowsPowerShell\3.0\System.Management.Automation.dll" 
//Verbs: https://msdn.microsoft.com/en-us/library/ms714428(v=vs.85).aspx

//Powershell starten
//Import-Module c:\MVA\CSharpSnippets\CmdLet\PowerShellCmdLet\PowerShellCmdLet\bin\Debug\PowerShellCmdLet.dll
//Get-Module
//Get-Help Get-SummeCSharp

//Get-SummeCSharp -Number1 10 -Number2 11


namespace PowerShellCmdLet
{
    [Cmdlet(VerbsCommon.Get, "SummeCSharp")]
    public class GetCalculation : PSCmdlet
    {

        [Parameter(Mandatory=true, Position = 1)]
        public int Number1 { get; set; }
        [Parameter(Mandatory = true,
            Position = 2,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true)]
        public int Number2 { get; set; }


        protected override void BeginProcessing()
        {
            base.BeginProcessing();
        }

        protected override void ProcessRecord()
        {
            WriteVerbose(string.Format("Calculating: {0} {1}", Number1, Number2));
            int result = Number1 + Number2;
            WriteObject(result);
        }

        protected override void EndProcessing()
        {
            base.EndProcessing();
        }


    }
}
