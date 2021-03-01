# Introduction

The Azure IoT Models Repository enables builders to manage and share digital twin models. The models are [JSON-LD][json_ld_reference] documents defined using the Digital Twins Definition Language ([DTDL][dtdlv2_reference]). Publishing models to the models repository requires [exercising][modelsrepository_msdocs] common GitHub workflows.

# IoT Models Repository Samples

You can explore the models repository APIs with the client library using the samples project.

The samples project demonstrates the following:

- Instantiate the client
- Get models and their dependencies
- Integration with the Digital Twins Model Parser

## Creating the models repository client

### Simple creation

```C# Snippet:IoTModelsRepositorySampleCreateServiceClientSimpleWithGlobalEndpoint
    // When no Uri is provided for instantiation. The global Azure IoT Models Repository endpoint is used
    // (https://devicemodels.azure.com/) and the dependency model resolution option is set to TryFromExpanded.
    var client = new ModelsRepositoryClient();
    Console.WriteLine($"Initialized client pointing to global endpoint: {client.RepositoryUri}");
```

### Override options

If you need to override pipeline behavior, such as provide your own HttpClient instance, you can do that via the other constructor that takes a
[DigitalTwinsClientOptions](https://github.com/Azure/azure-sdk-for-net/blob/master/sdk/digitaltwins/Azure.DigitalTwins.Core/src/DigitalTwinsClientOptions.cs) parameter.
It provides an opportunity to override default behavior including:

- Overriding [transport](https://github.com/Azure/azure-sdk-for-net/blob/master/sdk/core/Azure.Core/samples/Pipeline.md)
- Enabling [diagnostics](https://github.com/Azure/azure-sdk-for-net/blob/master/sdk/core/Azure.Core/samples/Diagnostics.md)
- Controlling [retry strategy](https://github.com/Azure/azure-sdk-for-net/blob/master/sdk/core/Azure.Core/samples/Configuration.md)
- Specifying API version


You can explore the digital twins APIs (using the client library) using the samples project.

<!-- LINKS -->
[microsoft_sdk_download]: https://azure.microsoft.com/downloads/?sdk=net
[azure_sdk_target_frameworks]: https://github.com/azure/azure-sdk-for-net#target-frameworks
[source]: https://github.com/Azure/azure-sdk-for-net/tree/master/sdk/modelsrepository/Azure.Iot.ModelsRepository/src
[code_of_conduct]: https://opensource.microsoft.com/codeofconduct/
[code_of_conduct_faq]: https://opensource.microsoft.com/codeofconduct/faq/
[nuget]: https://www.nuget.org/
[azure_core_library]: https://github.com/Azure/azure-sdk-for-net/tree/master/sdk/core/Azure.Core
[modelsrepository_msdocs]: https://docs.microsoft.com/en-us/azure/iot-pnp/concepts-model-repository
[modelsrepository_iot_endpoint]: https://devicemodels.azure.com/
[modelsrepository_samples]: https://github.com/Azure/azure-sdk-for-net/blob/master/sdk/modelsrepository/Azure.Iot.ModelsRepository/samples
[json_ld_reference]: https://json-ld.org
[dtdlv2_reference]: https://github.com/Azure/opendigitaltwins-dtdl/blob/master/DTDL/v2/dtdlv2.md
[eventsourcelistener_reference]: https://docs.microsoft.com/dotnet/api/azure.core.diagnostics.azureeventsourcelistener?view=azure-dotnet
