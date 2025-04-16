class MappingCollection:
    def __init__(self, textures=(), scalars=(), vectors=(), switches=(), component_masks=()):
        self.textures = textures
        self.scalars = scalars
        self.vectors = vectors
        self.switches = switches
        self.component_masks = component_masks


class SlotMapping:
    def __init__(self, name, slot=None, alpha_slot=None, switch_slot=None, value_func=None, coords="UV0"):
        self.name = name
        self.slot = name if slot is None else slot
        self.alpha_slot = alpha_slot
        self.switch_slot = switch_slot
        self.value_func = value_func
        self.coords = coords

default_mappings = MappingCollection(
    textures=[
        SlotMapping("Diffuse"),
        SlotMapping("D", "Diffuse"),
        SlotMapping("Base Color", "Diffuse"),
        SlotMapping("BaseColorMap", "Diffuse"),
        SlotMapping("BaseColorMap_a", "Diffuse"),
        SlotMapping("BaseColorMap_b", "Diffuse"),
        SlotMapping("BaseColorMap_c", "Diffuse"),
        SlotMapping("Base_BaseColor", "Diffuse"),
        SlotMapping("Albedo", "Diffuse"),
        SlotMapping("DiffuseMap", "Diffuse", alpha_slot="Alpha"),
        SlotMapping("Param", "Diffuse", alpha_slot="Alpha"),
        SlotMapping("BaseColor", "Diffuse"),
        SlotMapping("Concrete", "Diffuse"),
        SlotMapping("Trunk_BaseColor", "Diffuse"),
        SlotMapping("Diffuse Top", "Diffuse"),
        SlotMapping("BaseColor_Trunk", "Diffuse"),
        SlotMapping("CliffTexture", "Diffuse"),
        SlotMapping("PM_Diffuse", "Diffuse"),
        SlotMapping("___Diffuse", "Diffuse"),
        SlotMapping("CloudTexture", "Diffuse", alpha_slot="Alpha"),
        SlotMapping("DIFF", "Diffuse", alpha_slot="Alpha"),
        SlotMapping("op_tex", "Alpha"),

        SlotMapping("Background Diffuse", alpha_slot="Background Diffuse Alpha"),
        SlotMapping("BG Diffuse Texture", "Background Diffuse", alpha_slot="Background Diffuse Alpha"),

        SlotMapping("M"),
        SlotMapping("Mask", "M"),
        SlotMapping("AO", "M"),
        SlotMapping("M Mask", "M"),

        SlotMapping("SpecularMasks"),
        SlotMapping("S", "SpecularMasks"),
        SlotMapping("SRM", "SpecularMasks"),
        SlotMapping("S Mask", "SpecularMasks"),
        SlotMapping("Specular Mask", "SpecularMasks"),
        SlotMapping("CombinedMask_a", "SpecularMasks"),
        SlotMapping("CombinedMask_b", "SpecularMasks"),
        SlotMapping("CombinedMask_c", "SpecularMasks"),
        SlotMapping("Base_MROH", "SpecularMasks"),
        SlotMapping("MROMap", "SpecularMasks"),
        SlotMapping("ORM", "SpecularMasks"),
        SlotMapping("MRO", "SpecularMasks"),
        SlotMapping("BaseMask", "SpecularMasks"),
        SlotMapping("SpecularMask", "SpecularMasks"),
        SlotMapping("Concrete_SpecMask", "SpecularMasks"),
        SlotMapping("Trunk_Specular", "SpecularMasks"),
        SlotMapping("Specular Top", "SpecularMasks"),
        SlotMapping("SMR_Trunk", "SpecularMasks"),
        SlotMapping("Cliff Spec Texture", "SpecularMasks"),
        SlotMapping("PM_SpecularMasks", "SpecularMasks"),
        SlotMapping("__PBR Masks", "SpecularMasks"),

        SlotMapping("Normals"),
        SlotMapping("N", "Normals"),
        SlotMapping("NormalMap_a", "Normals"),
        SlotMapping("NormalMap_b", "Normals"),
        SlotMapping("NormalMap_c", "Normals"),
        SlotMapping("Base_Normal", "Normals"),
        SlotMapping("BaseNormal", "Normals"),
        SlotMapping("Noemal_tex", "Normals"),
        SlotMapping("Normal", "Normals"),
        SlotMapping("NormalMap", "Normals"),
        SlotMapping("ConcreteTextureNormal", "Normals"),
        SlotMapping("Trunk_Normal", "Normals"),
        SlotMapping("Normals Top", "Normals"),
        SlotMapping("Normal_Trunk", "Normals"),
        SlotMapping("CliffNormal", "Normals"),
        SlotMapping("PM_Normals", "Normals"),
        SlotMapping("_Normal", "Normals"),
        
        SlotMapping("AnisotropicTangentWeight", alpha_slot="AnisotropicTangentWeight Alpha"),
        SlotMapping("AnisotropigTangentWeight", "AnisotropicTangentWeight", alpha_slot="AnisotropicTangentWeight Alpha"),

        SlotMapping("Emissive", "Emission"),
        SlotMapping("EmissiveMask", "Emission"),
        SlotMapping("InterEmiss - CellMask", "Emission"),
        SlotMapping("EmissiveTexture", "Emission"),
        SlotMapping("L1_Emissive", "Emission", coords="UV2"),
        SlotMapping("PM_Emissive", "Emission"),
        SlotMapping("Visor_Emissive", "Emission"),
        SlotMapping("EmissiveDistanceField"),
        SlotMapping("Visor_EmissiveDistanceField"),

        SlotMapping("MaskTexture"),
        SlotMapping("OpacityMask", "MaskTexture"),

        SlotMapping("SkinFX_Mask"),
        SlotMapping("SkinFX Mask", "SkinFX_Mask"),
        SlotMapping("TechArtMask", "SkinFX_Mask"),
        SlotMapping("FxMask", "SkinFX_Mask"),
        
        SlotMapping("Thin Film Texture"),

        SlotMapping("IceGradient"),

        SlotMapping("ClothFuzz Texture"),

        SlotMapping("Flipbook", "Flipbook Color", alpha_slot="Flipbook Alpha"),
        SlotMapping("MouthFlipbook", "Flipbook Color", alpha_slot="Flipbook Alpha"),
    ],
    scalars=[
        SlotMapping("RoughnessMin", "Roughness Min"),
        SlotMapping("SpecRoughnessMin", "Roughness Min"),
        SlotMapping("RawRoughnessMin", "Roughness Min"),
        SlotMapping("Rough Min", "Roughness Min"),
        SlotMapping("RoughnessMax", "Roughness Max"),
        SlotMapping("SpecRoughnessMax", "Roughness Max"),
        SlotMapping("RawRoughnessMax", "Roughness Max"),
        SlotMapping("Rough Max", "Roughness Max"),
        SlotMapping("emissive mult", "Emission Strength"),
        SlotMapping("DayMult", "Emission Strength"),

        SlotMapping("ThinFilm_Intensity"),
        SlotMapping("ThinFilmIntensity", "ThinFilm_Intensity"),
        SlotMapping("ThinFilm_RoughnessScale"),
        SlotMapping("ThinFilmRoughnessScale", "ThinFilm_RoughnessScale"),
        SlotMapping("ThinFilm_Exponent"),
        SlotMapping("ThinFilmExponent", "ThinFilm_Exponent"),
        SlotMapping("ThinFilm_Offset"),
        SlotMapping("ThinFilmOffset", "ThinFilm_Offset"),
        SlotMapping("ThinFilm_Scale"),
        SlotMapping("ThinFilmScale", "ThinFilm_Scale"),
        SlotMapping("ThinFilm_Warp"),
        SlotMapping("ThinFilmWarp", "ThinFilm_Warp"),

        SlotMapping("Ice Fresnel"),
        SlotMapping("Ice Brightness"),
        SlotMapping("Ice Emissive Brightness"),
        SlotMapping("Crystal_FresEX"),

        SlotMapping("EmissiveFresnelPower"),
        SlotMapping("Emissive Fres EX", "EmissiveFresnelPower"),
        SlotMapping("Invert Emissive Fresnel", "InvertEmissiveFresnel"),

        SlotMapping("AnisotropyMaxWeight"),

        SlotMapping("Fuzz Tiling"),
        SlotMapping("ClothFuzzTiling", "Fuzz Tiling"),
        SlotMapping("Fuzz Exponent"),
        SlotMapping("ClothFuzzExponent", "Fuzz Exponent"),
        SlotMapping("Fuzz Fresnel Blend"),
        SlotMapping("Cloth Base Color Intensity"),
        SlotMapping("Cloth_BaseColorIntensity", "Cloth Base Color Intensity"),
        SlotMapping("Cloth Roughness"),
        SlotMapping("Cloth_Roughness", "Cloth Roughness"),

        SlotMapping("Undercoat Roughness"),
        SlotMapping("UndercoatRoughness"),
        SlotMapping("Undercoat Metallic Multiplier"),
        SlotMapping("UndercoatMetallicMultiplier"),
        SlotMapping("Roughness Map Now affects Clearcoat roughness", "Use Roughness Map"),

        SlotMapping("SubImages"),
        SlotMapping("Flipbook X"),
        SlotMapping("Flipbook Y"),
        SlotMapping("Flipbook Scale"),
        SlotMapping("Use Second UV Channel", "Use Second UV"),

        SlotMapping("SubUV_Frames"),
        SlotMapping("Affects Base Color"),
        SlotMapping("Multiply Flipbook Emissive")

    ],
    vectors=[
        SlotMapping("color", "Background Diffuse"),
        SlotMapping("Skin Boost Color And Exponent", "Skin Color", alpha_slot="Skin Boost"),
        SlotMapping("SkinTint", "Skin Color", alpha_slot="Skin Boost"),
        SlotMapping("SkinColor", "Skin Color", alpha_slot="Skin Boost"),
        SlotMapping("EmissiveMultiplier", "Emission Multiplier"),
        SlotMapping("Emissive Multiplier", "Emission Multiplier"),
        SlotMapping("Emissive Color", "Emission Multiplier"),
        SlotMapping("EmissiveColor", "Emission Multiplier"),
        SlotMapping("Emissive", "Emission Multiplier"),

        SlotMapping("ThinFilm_Channel"),
        SlotMapping("ThinFilmMaskChannel", "ThinFilm_Channel"),
        SlotMapping("Ice Channel"),
        SlotMapping("Cloth Channel"),
        SlotMapping("ClothFuzzMaskChannel", "Cloth Channel"),

        SlotMapping("Fuzz Tint"),
        SlotMapping("ClothFuzzTint", "Fuzz Tint"),
        SlotMapping("Cloth Fuzz Tint", "Fuzz Tint"),

        SlotMapping("FlipbookTint"),
        
        SlotMapping("CloatcoatMaskChannel")
    ],
    switches=[
        SlotMapping("SwizzleRoughnessToGreen"),
        SlotMapping("UseEmissiveFresnel"),
        SlotMapping("Use Emissive Fresnel", "UseEmissiveFresnel"),
        SlotMapping("InvertEmissiveFresnel"),
        SlotMapping("UseAnisotropicShading"),
        SlotMapping("Use Thin Film"),
        SlotMapping("UseThinFilm", "Use Thin Film"),
        SlotMapping("Use Cloth Fuzz"),
        SlotMapping("UseClothFuzz", "Use Cloth Fuzz"),
        SlotMapping("Use Ice"),
        SlotMapping("Use Clear Coat"),
        SlotMapping("UseClearCoat", "Use Clear Coat"),
        SlotMapping("Use Sub UV texture", "Use Flipbook")
    ],
    component_masks=[
        SlotMapping("ThinFilm_Channel"),
        SlotMapping("ThinFilmMaskChannel", "ThinFilm_Channel"),
        SlotMapping("Ice Channel"),
        SlotMapping("Cloth Channel"),
        SlotMapping("ClothFuzzMaskChannel", "Cloth Channel"),
        SlotMapping("Clear Coat Channel"),
        SlotMapping("ClearCoatChannel"),
        SlotMapping("CloatcoatMaskChannel"),
        SlotMapping("ClearcoatMaskChannel"),
    ]
)

layer_mappings = MappingCollection(
    textures=[
        SlotMapping("Diffuse", alpha_slot="MaskTexture"),
        SlotMapping("SpecularMasks"),
        SlotMapping("Normals"),
        SlotMapping("EmissiveTexture"),
        SlotMapping("MaskTexture"),
        SlotMapping("Background Diffuse", alpha_slot="Background Diffuse Alpha"),

        SlotMapping("Diffuse_Texture_2", alpha_slot="MaskTexture_2"),
        SlotMapping("SpecularMasks_2"),
        SlotMapping("Normals_Texture_2"),
        SlotMapping("Emissive_Texture_2"),
        SlotMapping("MaskTexture_2"),
        SlotMapping("Background Diffuse 2", alpha_slot="Background Diffuse Alpha 2"),

        SlotMapping("Diffuse_Texture_3", alpha_slot="MaskTexture_3"),
        SlotMapping("SpecularMasks_3"),
        SlotMapping("Normals_Texture_3"),
        SlotMapping("Emissive_Texture_3"),
        SlotMapping("MaskTexture_3"),
        SlotMapping("Background Diffuse 3", alpha_slot="Background Diffuse Alpha 3"),

        SlotMapping("Diffuse_Texture_4", alpha_slot="MaskTexture_4"),
        SlotMapping("SpecularMasks_4"),
        SlotMapping("Normals_Texture_4"),
        SlotMapping("Emissive_Texture_4"),
        SlotMapping("MaskTexture_4"),
        SlotMapping("Background Diffuse 4", alpha_slot="Background Diffuse Alpha 4"),

        SlotMapping("Diffuse_Texture_5", alpha_slot="MaskTexture_5"),
        SlotMapping("SpecularMasks_5"),
        SlotMapping("Normals_Texture_5"),
        SlotMapping("Emissive_Texture_5"),
        SlotMapping("MaskTexture_5"),
        SlotMapping("Background Diffuse 5", alpha_slot="Background Diffuse Alpha 5"),

        SlotMapping("Diffuse_Texture_6", alpha_slot="MaskTexture_6"),
        SlotMapping("SpecularMasks_6"),
        SlotMapping("Normals_Texture_6"),
        SlotMapping("Emissive_Texture_6"),
        SlotMapping("MaskTexture_6"),
        SlotMapping("Background Diffuse 6", alpha_slot="Background Diffuse Alpha 6"),
    ]
)

fnaf_character_mappings = MappingCollection(
    textures=[
        SlotMapping("Base Color"),
        SlotMapping("D", "Base Color"),
        SlotMapping("BC", "Base Color"),
        SlotMapping("Texture", "Base Color"),
        SlotMapping("Base_Color", "Base Color"),
        SlotMapping("BaseColor", "Base Color"),
        SlotMapping("basecolor", "Base Color"),
        SlotMapping("MASK", "Base Color"),
        SlotMapping("COLOR", "Base Color"),
        SlotMapping("Albedo", "Base Color"),
        SlotMapping("AlbedoTexture", "Base Color"),
        SlotMapping("BaseMap", "Base Color"),
        SlotMapping("Diffuse", "Base Color"),
        SlotMapping("Color Texture", "Base Color"),
        SlotMapping("DiffuseTexture", "Base Color"),
        SlotMapping("T_Floor_BC", "Base Color", alpha_slot="Alpha"),
        
        SlotMapping("Sprite", "Base Color"), # TODO: Replace with proper Sprite material handling
        
        SlotMapping("AO"),
        SlotMapping("OcclusionMap", "AO"),
        
        SlotMapping("ORM"),
        SlotMapping("AORM", "ORM"),
        SlotMapping("Packed", "ORM"),
        SlotMapping("ORM Texture", "ORM"),
        SlotMapping("MergeMapInput", "ORM"),
        SlotMapping("AO_Rough_Metal", "ORM"),
        SlotMapping("AmbientOcclusionTexture", "ORM"),
        SlotMapping("AO(R) Rough(G) Metallic(B)", "ORM"),
        
        SlotMapping("R", "Roughness"),
        SlotMapping("Roughness", "Roughness"),
        SlotMapping("Roughness Map", "Roughness"),
        
        SlotMapping("MT", "Metallic"),
        SlotMapping("MetallicMap", "Metallic"),
        SlotMapping("MetallicTexture", "Metallic"),
        
        SlotMapping("Normal"),
        SlotMapping("N", "Normal"),
        SlotMapping("Norm", "Normal"),
        SlotMapping("Normal Map", "Normal"),
        SlotMapping("NormalTexture", "Normal"),
        SlotMapping("Normal Texture", "Normal"),
        SlotMapping("MainNormalInput", "Normal"),
        SlotMapping("NormalBase_Color_1", "Normal"),
        
        SlotMapping("Emissive", "Emission Color"),
        SlotMapping("EmissiveMap", "Emission Color"),
        
        SlotMapping("Alpha"),
        SlotMapping("Opacity", "Alpha"),
        SlotMapping("OpacityMaskTexture", "Alpha"),
    ],
    scalars=[
        SlotMapping("Rough", "Roughness"),
        SlotMapping("Roughness", "Roughness"),
        SlotMapping("Roughness Adjust", "Roughness"),
        
        SlotMapping("NormalStrength", "Normal Strength"),
        
        SlotMapping("Emission Strength"),
        SlotMapping("EM_Amount", "Emission Strength"),
        
        SlotMapping("Opacity", "Alpha"),
    ],
    vectors=[
        SlotMapping("Color", "Base Color"),
        SlotMapping("Base Color Value", "Base Color"),
        
        SlotMapping("Tint", "Base Color Multiply"),
        SlotMapping("Color1", "Base Color Multiply"),
        SlotMapping("ColorA", "Base Color Multiply"),
        SlotMapping("Color01", "Base Color Multiply"),
        SlotMapping("ColorMult", "Base Color Multiply"),
        SlotMapping("ColorSide2", "Base Color Multiply"),
        SlotMapping("LightColor", "Base Color Multiply"),
        SlotMapping("Color Overlay", "Base Color Multiply"),
        SlotMapping("Color_Multiply", "Base Color Multiply"),
        SlotMapping("Base_Color_Multiply", "Base Color Multiply"),
        SlotMapping("EmissiveColor", "Emission Color"),
        SlotMapping("Em_Color", "Custom Color"),
    ]
)