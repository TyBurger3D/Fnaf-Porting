#define LOCTEXT_NAMESPACE "FFNAFPortingModule"
#include "FNAFPorting.h"

#include "Classes/BuildingTextureData.h"
#include "Renderers/BuildingTextureDataThumbnailRenderer.h"
#include "ThumbnailRendering/ThumbnailManager.h"

DEFINE_LOG_CATEGORY(LogFNAFPorting);

void FFNAFPortingModule::StartupModule()
{
	ListenServer = new FListenServer();
	
	UThumbnailManager::Get().RegisterCustomRenderer(
		UBuildingTextureData::StaticClass(), 
		UBuildingTextureDataThumbnailRenderer::StaticClass()
	);
}

void FFNAFPortingModule::ShutdownModule()
{
	delete ListenServer;
}

#undef LOCTEXT_NAMESPACE
	
IMPLEMENT_MODULE(FFNAFPortingModule, FNAFPorting)