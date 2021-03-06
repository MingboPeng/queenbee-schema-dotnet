
# QueenbeeSDK.Model.Recipe

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Flow** | [**List&lt;DAG&gt;**](DAG.md) | A list of tasks to create a DAG recipe. | 
**Type** | **string** |  | [optional] [readonly] [default to "Recipe"]
**Annotations** | **Dictionary&lt;string, string&gt;** | An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries. | [optional] 
**ApiVersion** | **string** |  | [optional] [readonly] [default to "v1beta1"]
**Metadata** | [**MetaData**](MetaData.md) | Recipe metadata information. | [optional] 
**Dependencies** | [**List&lt;Dependency&gt;**](Dependency.md) | A list of plugins and other recipes this recipe depends on. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

