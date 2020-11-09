# Use a regular expression to get "minor, major, fix, revision" from the BUILD_BUILDNUMBER environment variable
# the build process will automatically set the value of the environment variable to the correct build number 
$VersionRegex = "\d+\.\d+\.\d+\.\d+"
$NewVersion = [regex]::matches($Env:BUILD_BUILDNUMBER,$VersionRegex)

Write-Host "Updating version of the application to the build version: " $NewVersion
$file = ".\SharedAssemblyInfo.cs" 
$filecontent = Get-Content($file)
attrib $file -r

