#pragma once

#include "CoreMinimal.h"
#include "ListenServer.h"
#include "Modules/ModuleManager.h"

DECLARE_LOG_CATEGORY_EXTERN(LogFNAFPorting, Log, All);

class FFNAFPortingModule : public IModuleInterface
{
public:

	FListenServer* ListenServer;
	
	virtual void StartupModule() override;
	virtual void ShutdownModule() override;
};
