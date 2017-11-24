namespace ValDrive.CustomRender
{
    public interface IMapRender
    {
        void SetRenderer(IRendererFunction renderer);

        void CalculoRotaFinalizado();
    }
}
