﻿namespace MultiShop.Catalog.DTOs.FeatureSliderDTOs;

public class GetByIdFeatureSliderDTO
{
    public string FeatureSliderId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    public bool Status { get; set; }
}